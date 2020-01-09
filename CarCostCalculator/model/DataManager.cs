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

        public bool LicensePlate(string email, string canton, double power, string formatPower, double weight, double co2Emission)
        {
            bool licensePlate = true;

            if(formatPower == "ch")
            {
                power = power * 0.74;
            }

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

        public double DoCalculLicensePlate(string canton, double power, string formatPower, double weight, double co2Emission)
        {
            int costYear = 0;
            double powerCalculated;
            double weightCalculated;

            if (formatPower == "ch")
            {
                power = power * 0.74;
            }

            switch (canton)
            {
                case "Vaud":
                    
                    //PowerCalcul
                    if(power < 100)
                    {
                        powerCalculated = power * 2;
                    }
                    else
                    {
                        powerCalculated = ((power - 100) * 3) + 200;
                    }

                    //WeightCalcul
                    if(weight < 2000)
                    {
                        weightCalculated = weight * 0.15;
                    }
                    else
                    {
                        weightCalculated =((weight - 2000) * 0.3) + 300;
                    }

                    break;
                default:
                    
                    break;
            }

            return costYear;
        }
    }
}
