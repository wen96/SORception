﻿using ManagerSystem.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManagerSystem.Services
{
    public class BaseService : IDisposable
    {
        private UnitOfWork unit_of_work = null;
        protected UnitOfWork unitOfWork
        {
            get
            {
                if (this.unit_of_work == null)
                    this.unit_of_work = new UnitOfWork();
                return this.unit_of_work;
            }
        }

        /*
         * Services offered by the application
         * */

        private ConfigService config_service = null;
        protected ConfigService configService
        {
            get
            {
                if (this.config_service == null)
                    this.config_service = new ConfigService(unitOfWork);
                return this.config_service;
            }
        }

        private TokenService token_service = null;
        protected TokenService tokenService
        {
            get
            {
                if (this.token_service == null)
                    this.token_service = new TokenService(unitOfWork);
                return this.token_service;
            }
        }

        private AESService aes_service = null;
        protected AESService aesService
        {
            get
            {
                if (this.aes_service == null)
                    this.aes_service = new AESService(unitOfWork);
                return this.aes_service;
            }
        }

        private OfferService offer_service = null;
        protected OfferService offerService
        {
            get
            {
                if (this.offer_service == null)
                    this.offer_service = new OfferService(unitOfWork);
                return this.offer_service;
            }
        }

        private AuthService auth_service = null;
        protected AuthService authService
        {
            get
            {
                if (this.auth_service == null)
                    this.auth_service = new AuthService(unitOfWork);
                return this.auth_service;
            }
        }

        private GarageService garage_service = null;
        protected GarageService garageService
        {
            get
            {
                if (this.garage_service == null)
                    this.garage_service = new GarageService(unitOfWork);
                return this.garage_service;
            }
        }

        private JunkyardService junkyard_service = null;
        protected JunkyardService junkyardService
        {
            get
            {
                if (this.junkyard_service == null)
                    this.junkyard_service = new JunkyardService(unitOfWork);
                return this.junkyard_service;
            }
        }

        private JobService job_service = null;
        protected JobService jobService
        {
            get
            {
                if (this.job_service == null)
                    this.job_service = new JobService(unitOfWork);
                return this.job_service;
            }
        }

        private AMQService amq_service = null;
        protected AMQService amqService
        {
            get
            {
                if (this.amq_service == null)
                    this.amq_service = new AMQService(unitOfWork);
                return this.amq_service;
            }
        }

        private OrderService order_service = null;
        protected OrderService orderService
        {
            get
            {
                if (this.order_service == null)
                    this.order_service = new OrderService(unitOfWork);
                return this.order_service;
            }
        }

        private PurchaseService purchase_service = null;
        protected PurchaseService purchaseService
        {
            get
            {
                if (this.purchase_service == null)
                    this.purchase_service = new PurchaseService(unitOfWork);
                return this.purchase_service;
            }
        }

        private LogService log_service = null;
        protected LogService logService
        {
            get
            {
                if (this.log_service == null)
                    this.log_service = new LogService(unitOfWork);
                return this.log_service;
            }
        }

        public BaseService(UnitOfWork uOW = null)
        {
            this.unit_of_work = uOW;
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.unitOfWork.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}