﻿using ScrapWeb.DataAccess;
using ScrapWeb.Entities;
using ScrapWeb.Exceptions;
using ScrapWeb.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace ScrapWeb.Services
{
    public class TokenService
    {
        protected LogsRepository Logs;
        private ScrapContext scrapContext;
        private GenericRepository<TokenEntity> tokenRepository;

        private SGService sgService;
        private AMQService amqService;

        public TokenService()
        {
            scrapContext = new ScrapContext();
            tokenRepository = new GenericRepository<TokenEntity>(scrapContext);
            sgService = new SGService();
            amqService = new AMQService();
            Logs = new LogsRepository(scrapContext);
        }

        public IEnumerable<TokenEntity> getAll() {
            return tokenRepository.GetAll();
        }

        public TokenEntity requestToken()
        {
            // Set valid tokens to null
            nullValidTokens();

            // Disable topic subscriber
            amqService.destroyTopicSubscribers();

            // Request new token as temporal
            TokenEntity tokenEntity = sgService.signUp();
            tokenRepository.Insert(tokenEntity);

            // Save changes and return
            Logs.create(LogEntity.INFO, "Topic subscribed " + tokenEntity.token + "with status " + tokenEntity.status);
            scrapContext.SaveChanges();
            return tokenEntity;
        }

        public TokenEntity getValid()
        {
            var tokenEntity = tokenRepository
                .Get(t => t.status == TokenStatus.VALID)
                .FirstOrDefault();
            if (tokenEntity == null)
            {
                // Check if we have requested one
                tokenEntity = tokenRepository
                    .Get(t => (t.status == TokenStatus.REQUESTED || t.status == TokenStatus.TEMPORAL))
                    .FirstOrDefault();
                if (tokenEntity == null)
                {
                    Logs.create(LogEntity.ERROR, "Not valid token or request was found");
                    throw new ServiceException("Not valid token or request was found", HttpStatusCode.NotFound);
                }
                // Check if token is available
                tokenEntity = sgService.getState(tokenEntity.token);
                tokenRepository.Insert(tokenEntity);
                // Save changes
                scrapContext.SaveChanges();
                // If not available, 404
                if (tokenEntity.status != TokenStatus.VALID)
                {
                    Logs.create(LogEntity.ERROR, "Token request has not been accepted");
                    throw new ServiceException("Token request has not been accepted", HttpStatusCode.NotFound);                
                }
                // If we have a token, enable it here

                Logs.create(LogEntity.INFO, "Topic subscribed "+tokenEntity.token+ "with status "+tokenEntity.status);
                amqService.createTopicSubscribers(tokenEntity);
            }
            return tokenEntity;
        }

        private void nullValidTokens()
        {
            var tokens = tokenRepository.Get(t => t.status == TokenStatus.VALID);
            foreach (var token in tokens)
            {
                token.status = TokenStatus.EXPIRED;
                tokenRepository.Update(token);
            }
        }
    }
}