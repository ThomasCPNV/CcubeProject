using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class DataManager
    {
        private DBConnect dbConnect = new DBConnect();

        public bool LicensePlate(string email, string canton, double power, double weight, double co2Emission, double costYear, double costMonth)
        {
            bool licensePlate = true;

            if(dbConnect.InsertLicensePlate(canton, power, weight, co2Emission, costYear, costMonth))
            {
                dbConnect.InsertIdLicensePlate(email);
            }
            else
            {
                licensePlate = false;
            }

            return licensePlate;
        }

        public bool EssentialMaintain(string email, double insuranceYear, double tiresYear, double revisionYear, double costYear, double costMonth)
        {
            bool essentialMaintain = true;

            if(dbConnect.InsertEssentialMaintain(insuranceYear, tiresYear, revisionYear, costYear, costMonth))
            {
                dbConnect.InsertIdEssentialMaintain(email);
            }
            else
            {
                essentialMaintain = false;
            }

            return essentialMaintain;
        }

        public bool InitialPrice(string email, double purchasePrice, double lifeTime, double costYear, double costMonth)
        {
            bool initialPrice = true;

            if(dbConnect.InsertInitialCarPrice(purchasePrice, lifeTime, costYear, costMonth))
            {
                dbConnect.InsertIdIntialPrice(email);
            }
            else
            {
                initialPrice = false;
            }

            return initialPrice;
        }

        public bool Consommation(string email, string fuel, double fuelPrice, double consomation, double distanceMonth, double costYear, double costMonth)
        {
            bool consommation = true;

            if(dbConnect.InsertConsommation(fuel, fuelPrice, consomation, distanceMonth, costYear, costMonth))
            {
                dbConnect.InsertIdConsommation(email);
            }
            else
            {
                consommation = false;
            }

            return consommation;
        }
    }
}
