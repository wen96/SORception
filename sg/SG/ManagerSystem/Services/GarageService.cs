﻿using ManagerSystem.DataAccess;
using ManagerSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Web;

namespace ManagerSystem.Services
{
    public class GarageService : BaseService
    {
        public GarageService(UnitOfWork uow = null) : base(uow) { }

        public TokenResponse createGarage(ExpTaller e_garage)
        {
            if (e_garage != null)
            {
                GarageEntity garage  = new GarageEntity();
                garage.name = e_garage.name;
                garage.tokens.Add(tokenService.createGarageToken(TokenType.TEMPORAL));

                unitOfWork.GarageRepository.Insert(garage);

                unitOfWork.Save();

                return new TokenResponse(garage.current_token, TokenResponse.Code.ACCEPTED);
            }
            return new TokenResponse("", TokenResponse.Code.BAD_REQUEST);
        }

        public void putGarage(ExpTaller e_garage)
        {
            GarageEntity garage = this.getCurrentGarage();

            garage.name = e_garage.name;
            unitOfWork.GarageRepository.Update(garage);

            unitOfWork.Save();
        }

        public void deleteCurrentGarage()
        {
            GarageEntity garage = this.getCurrentGarage();

            unitOfWork.GarageRepository.Get(g => g.id == garage.id, null, "tokens,orders");
            unitOfWork.GarageRepository.Delete(garage);

            unitOfWork.Save();
        }

        public GarageEntity getCurrentGarage()
        {
            string token_string = authorizationService.getCurrentToken();

            return this.getGarageWithToken(token_string);
        }

        public GarageEntity getGarageWithToken(string token_string)
        {
            return tokenService.getGarage(token_string);
        }

        public GarageEntity getGarage(int garage_id)
        {
            GarageEntity garage = unitOfWork.GarageRepository.GetByID(garage_id);
            if (garage == null)
                throw new ArgumentException();

            return garage;
        }

        public List<GarageEntity> getGarages()
        {
            List<GarageEntity> garages = (from garage in unitOfWork.GarageRepository.GetAll() select garage).ToList();
            return garages;
        }

        public void activateGarage(int garage_id, bool is_active)
        {
            GarageEntity garage = unitOfWork.GarageRepository.GetByID(garage_id);
            if (garage == null)
                throw new ArgumentException();

            garage.status = is_active ? GarageStatus.ACTIVE : GarageStatus.CREATED;

            unitOfWork.GarageRepository.Update(garage);
            unitOfWork.Save();
        }

        public bool existsGarageWithToken(string token_string)
        {
            try
            {
                this.getGarageWithToken(token_string);
            }
            catch (ArgumentException)
            {
                return false;
            }
            return true;
        }

        public void removeGarage(int garage_id)
        {
            GarageEntity garage = unitOfWork.GarageRepository.GetByID(garage_id);

            if (garage == null)
                throw new ArgumentNullException();

            unitOfWork.GarageRepository.Delete(garage);
            unitOfWork.Save();
        }
    }
}