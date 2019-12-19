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

        public bool LicensePlate(string email, string canton, double power, double weight, double co2Emission)
        {
            bool licensePlate = true;

            if(dbConnect.InsertLicensePlate(canton, power, weight, co2Emission))
            {
                dbConnect.InsertIdLicensePlate(email);
            }
            else
            {
                licensePlate = false;
            }

            return licensePlate;
        }

        public bool EssentialMaintain(string email, double insuranceYear, double tiresYear, double revisionYear)
        {
            bool essentialMaintain = true;

            if(dbConnect.InsertEssentialMaintain(insuranceYear, tiresYear, revisionYear))
            {
                dbConnect.InsertIdEssentialMaintain(email);
            }
            else
            {
                essentialMaintain = false;
            }

            return essentialMaintain;
        }

        public bool InitialPrice(string email, double purchasePrice, double lifeTime)
        {
            bool initialPrice = true;

            if(dbConnect.InsertInitialCarPrice(purchasePrice, lifeTime))
            {
                dbConnect.InsertIdIntialPrice(email);
            }
            else
            {
                initialPrice = false;
            }

            return initialPrice;
        }

        public bool Consommation(string email, string fuel, double consomation, double distanceMonth)
        {
            bool consommation = true;

            if(dbConnect.InsertConsommation(fuel, consomation, distanceMonth))
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
