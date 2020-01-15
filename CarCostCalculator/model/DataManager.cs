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

        public bool LicensePlate(string email, string canton, double power, string formatPower, double weight, double co2Emission, double costYear)
        {
            bool licensePlate = true;

            if(formatPower == "hp")
            {
                power = power * 0.74;
            }

            if(dbConnect.InsertLicensePlate(canton, power, weight, co2Emission, costYear))
            {
                dbConnect.InsertIdLicensePlate();
            }
            else
            {
                licensePlate = false;
            }

            return licensePlate;
        }

        public bool EssentialMaintain(string email, double insuranceYear, double tiresYear, double revisionYear, double costYear)
        {
            bool essentialMaintain = true;

            if(dbConnect.InsertEssentialMaintain(insuranceYear, tiresYear, revisionYear, costYear))
            {
                dbConnect.InsertIdEssentialMaintain();
            }
            else
            {
                essentialMaintain = false;
            }

            return essentialMaintain;
        }

        public bool InitialPrice(string email, double purchasePrice, double lifeTime, double costYear)
        {
            bool initialPrice = true;

            if(dbConnect.InsertInitialCarPrice(purchasePrice, lifeTime, costYear))
            {
                dbConnect.InsertIdIntialPrice();
            }
            else
            {
                initialPrice = false;
            }

            return initialPrice;
        }

        public bool Consommation(string email, string fuel, double consomation, double distanceMonth, double costYear)
        {
            bool consommation = true;

            if(dbConnect.InsertConsommation(fuel, consomation, distanceMonth, costYear))
            {
                dbConnect.InsertIdConsommation();
            }
            else
            {
                consommation = false;
            }

            return consommation;
        }

        public double CalculLicensePlate(string canton, double power, string formatPower, double weight, double co2Emission)
        {
            double costYear = 0;
            double powerCalculated;
            double weightCalculated;

            if (formatPower == "hp")
            {
                power = power * 0.74;
            }

            //Les nombres qui sont utilisés sont expliqués dans le fichier excel se trouvant dans le dossier Documentation du projet
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

                    //CostYear calcul
                    if(co2Emission > 120)
                    {
                        costYear = powerCalculated + weightCalculated + 40;
                    }
                    else
                    {
                        costYear = (powerCalculated + weightCalculated + 40) * 0.25;
                    }
                    break;
                case "Aargau":

                    //PowerCalcul
                    if (power < 100)
                    {
                        powerCalculated = power * 2;
                    }
                    else
                    {
                        powerCalculated = ((power - 100) * 3) + 200;
                    }

                    //WeightCalcul
                    if (weight < 2000)
                    {
                        weightCalculated = weight * 0.15;
                    }
                    else
                    {
                        weightCalculated = ((weight - 2000) * 0.3) + 300;
                    }

                    //CostYear calcul
                    if (co2Emission > 120)
                    {
                        costYear = powerCalculated + weightCalculated + 40;
                    }
                    else
                    {
                        costYear = (powerCalculated + weightCalculated + 40) * 0.25;
                    }
                    break;
                case "Appenzell Inner-Rhodes":

                    //PowerCalcul
                    if (power < 100)
                    {
                        powerCalculated = power * 2;
                    }
                    else
                    {
                        powerCalculated = ((power - 100) * 3) + 200;
                    }

                    //WeightCalcul
                    if (weight < 2000)
                    {
                        weightCalculated = weight * 0.15;
                    }
                    else
                    {
                        weightCalculated = ((weight - 2000) * 0.3) + 300;
                    }

                    //CostYear calcul
                    if (co2Emission > 120)
                    {
                        costYear = powerCalculated + weightCalculated + 40;
                    }
                    else
                    {
                        costYear = (powerCalculated + weightCalculated + 40) * 0.25;
                    }
                    break;
                case "Appenzell Outer-Rhodes":

                    //PowerCalcul
                    if (power < 100)
                    {
                        powerCalculated = power * 2;
                    }
                    else
                    {
                        powerCalculated = ((power - 100) * 3) + 200;
                    }

                    //WeightCalcul
                    if (weight < 2000)
                    {
                        weightCalculated = weight * 0.15;
                    }
                    else
                    {
                        weightCalculated = ((weight - 2000) * 0.3) + 300;
                    }

                    //CostYear calcul
                    if (co2Emission > 120)
                    {
                        costYear = powerCalculated + weightCalculated + 40;
                    }
                    else
                    {
                        costYear = (powerCalculated + weightCalculated + 40) * 0.25;
                    }
                    break;
                case "Basel":

                    //PowerCalcul
                    if (power < 100)
                    {
                        powerCalculated = power * 2;
                    }
                    else
                    {
                        powerCalculated = ((power - 100) * 3) + 200;
                    }

                    //WeightCalcul
                    if (weight < 2000)
                    {
                        weightCalculated = weight * 0.15;
                    }
                    else
                    {
                        weightCalculated = ((weight - 2000) * 0.3) + 300;
                    }

                    //CostYear calcul
                    if (co2Emission > 120)
                    {
                        costYear = powerCalculated + weightCalculated + 40;
                    }
                    else
                    {
                        costYear = (powerCalculated + weightCalculated + 40) * 0.25;
                    }
                    break;
                case "Basel District":

                    //PowerCalcul
                    if (power < 100)
                    {
                        powerCalculated = power * 2;
                    }
                    else
                    {
                        powerCalculated = ((power - 100) * 3) + 200;
                    }

                    //WeightCalcul
                    if (weight < 2000)
                    {
                        weightCalculated = weight * 0.15;
                    }
                    else
                    {
                        weightCalculated = ((weight - 2000) * 0.3) + 300;
                    }

                    //CostYear calcul
                    if (co2Emission > 120)
                    {
                        costYear = powerCalculated + weightCalculated + 40;
                    }
                    else
                    {
                        costYear = (powerCalculated + weightCalculated + 40) * 0.25;
                    }
                    break;
                case "Bem":

                    //PowerCalcul
                    if (power < 100)
                    {
                        powerCalculated = power * 2;
                    }
                    else
                    {
                        powerCalculated = ((power - 100) * 3) + 200;
                    }

                    //WeightCalcul
                    if (weight < 2000)
                    {
                        weightCalculated = weight * 0.15;
                    }
                    else
                    {
                        weightCalculated = ((weight - 2000) * 0.3) + 300;
                    }

                    //CostYear calcul
                    if (co2Emission > 120)
                    {
                        costYear = powerCalculated + weightCalculated + 40;
                    }
                    else
                    {
                        costYear = (powerCalculated + weightCalculated + 40) * 0.25;
                    }
                    break;
                case "Fribourg":

                    //PowerCalcul
                    if (power < 100)
                    {
                        powerCalculated = power * 2;
                    }
                    else
                    {
                        powerCalculated = ((power - 100) * 3) + 200;
                    }

                    //WeightCalcul
                    if (weight < 2000)
                    {
                        weightCalculated = weight * 0.15;
                    }
                    else
                    {
                        weightCalculated = ((weight - 2000) * 0.3) + 300;
                    }

                    //CostYear calcul
                    if (co2Emission > 120)
                    {
                        costYear = powerCalculated + weightCalculated + 40;
                    }
                    else
                    {
                        costYear = (powerCalculated + weightCalculated + 40) * 0.25;
                    }
                    break;
                case "Geneva":

                    //PowerCalcul
                    if (power < 100)
                    {
                        powerCalculated = power * 2;
                    }
                    else
                    {
                        powerCalculated = ((power - 100) * 3) + 200;
                    }

                    //WeightCalcul
                    if (weight < 2000)
                    {
                        weightCalculated = weight * 0.15;
                    }
                    else
                    {
                        weightCalculated = ((weight - 2000) * 0.3) + 300;
                    }

                    //CostYear calcul
                    if (co2Emission > 120)
                    {
                        costYear = powerCalculated + weightCalculated + 40;
                    }
                    else
                    {
                        costYear = (powerCalculated + weightCalculated + 40) * 0.25;
                    }
                    break;
                case "Glarus":

                    //PowerCalcul
                    if (power < 100)
                    {
                        powerCalculated = power * 2;
                    }
                    else
                    {
                        powerCalculated = ((power - 100) * 3) + 200;
                    }

                    //WeightCalcul
                    if (weight < 2000)
                    {
                        weightCalculated = weight * 0.15;
                    }
                    else
                    {
                        weightCalculated = ((weight - 2000) * 0.3) + 300;
                    }

                    //CostYear calcul
                    if (co2Emission > 120)
                    {
                        costYear = powerCalculated + weightCalculated + 40;
                    }
                    else
                    {
                        costYear = (powerCalculated + weightCalculated + 40) * 0.25;
                    }
                    break;
                case "Grisons":

                    //PowerCalcul
                    if (power < 100)
                    {
                        powerCalculated = power * 2;
                    }
                    else
                    {
                        powerCalculated = ((power - 100) * 3) + 200;
                    }

                    //WeightCalcul
                    if (weight < 2000)
                    {
                        weightCalculated = weight * 0.15;
                    }
                    else
                    {
                        weightCalculated = ((weight - 2000) * 0.3) + 300;
                    }

                    //CostYear calcul
                    if (co2Emission > 120)
                    {
                        costYear = powerCalculated + weightCalculated + 40;
                    }
                    else
                    {
                        costYear = (powerCalculated + weightCalculated + 40) * 0.25;
                    }
                    break;
                case "Jura":

                    //PowerCalcul
                    if (power < 100)
                    {
                        powerCalculated = power * 2;
                    }
                    else
                    {
                        powerCalculated = ((power - 100) * 3) + 200;
                    }

                    //WeightCalcul
                    if (weight < 2000)
                    {
                        weightCalculated = weight * 0.15;
                    }
                    else
                    {
                        weightCalculated = ((weight - 2000) * 0.3) + 300;
                    }

                    //CostYear calcul
                    if (co2Emission > 120)
                    {
                        costYear = powerCalculated + weightCalculated + 40;
                    }
                    else
                    {
                        costYear = (powerCalculated + weightCalculated + 40) * 0.25;
                    }
                    break;
                case "Lucerne":

                    //PowerCalcul
                    if (power < 100)
                    {
                        powerCalculated = power * 2;
                    }
                    else
                    {
                        powerCalculated = ((power - 100) * 3) + 200;
                    }

                    //WeightCalcul
                    if (weight < 2000)
                    {
                        weightCalculated = weight * 0.15;
                    }
                    else
                    {
                        weightCalculated = ((weight - 2000) * 0.3) + 300;
                    }

                    //CostYear calcul
                    if (co2Emission > 120)
                    {
                        costYear = powerCalculated + weightCalculated + 40;
                    }
                    else
                    {
                        costYear = (powerCalculated + weightCalculated + 40) * 0.25;
                    }
                    break;
                case "Neuchâtel":

                    //PowerCalcul
                    if (power < 100)
                    {
                        powerCalculated = power * 2;
                    }
                    else
                    {
                        powerCalculated = ((power - 100) * 3) + 200;
                    }

                    //WeightCalcul
                    if (weight < 2000)
                    {
                        weightCalculated = weight * 0.15;
                    }
                    else
                    {
                        weightCalculated = ((weight - 2000) * 0.3) + 300;
                    }

                    //CostYear calcul
                    if (co2Emission > 120)
                    {
                        costYear = powerCalculated + weightCalculated + 40;
                    }
                    else
                    {
                        costYear = (powerCalculated + weightCalculated + 40) * 0.25;
                    }
                    break;
                case "Nidwalden":

                    //PowerCalcul
                    if (power < 100)
                    {
                        powerCalculated = power * 2;
                    }
                    else
                    {
                        powerCalculated = ((power - 100) * 3) + 200;
                    }

                    //WeightCalcul
                    if (weight < 2000)
                    {
                        weightCalculated = weight * 0.15;
                    }
                    else
                    {
                        weightCalculated = ((weight - 2000) * 0.3) + 300;
                    }

                    //CostYear calcul
                    if (co2Emission > 120)
                    {
                        costYear = powerCalculated + weightCalculated + 40;
                    }
                    else
                    {
                        costYear = (powerCalculated + weightCalculated + 40) * 0.25;
                    }
                    break;
                case "Obwalden":

                    //PowerCalcul
                    if (power < 100)
                    {
                        powerCalculated = power * 2;
                    }
                    else
                    {
                        powerCalculated = ((power - 100) * 3) + 200;
                    }

                    //WeightCalcul
                    if (weight < 2000)
                    {
                        weightCalculated = weight * 0.15;
                    }
                    else
                    {
                        weightCalculated = ((weight - 2000) * 0.3) + 300;
                    }

                    //CostYear calcul
                    if (co2Emission > 120)
                    {
                        costYear = powerCalculated + weightCalculated + 40;
                    }
                    else
                    {
                        costYear = (powerCalculated + weightCalculated + 40) * 0.25;
                    }
                    break;
                case "Schaffhausen":

                    //PowerCalcul
                    if (power < 100)
                    {
                        powerCalculated = power * 2;
                    }
                    else
                    {
                        powerCalculated = ((power - 100) * 3) + 200;
                    }

                    //WeightCalcul
                    if (weight < 2000)
                    {
                        weightCalculated = weight * 0.15;
                    }
                    else
                    {
                        weightCalculated = ((weight - 2000) * 0.3) + 300;
                    }

                    //CostYear calcul
                    if (co2Emission > 120)
                    {
                        costYear = powerCalculated + weightCalculated + 40;
                    }
                    else
                    {
                        costYear = (powerCalculated + weightCalculated + 40) * 0.25;
                    }
                    break;
                case "Schwyz":

                    //PowerCalcul
                    if (power < 100)
                    {
                        powerCalculated = power * 2;
                    }
                    else
                    {
                        powerCalculated = ((power - 100) * 3) + 200;
                    }

                    //WeightCalcul
                    if (weight < 2000)
                    {
                        weightCalculated = weight * 0.15;
                    }
                    else
                    {
                        weightCalculated = ((weight - 2000) * 0.3) + 300;
                    }

                    //CostYear calcul
                    if (co2Emission > 120)
                    {
                        costYear = powerCalculated + weightCalculated + 40;
                    }
                    else
                    {
                        costYear = (powerCalculated + weightCalculated + 40) * 0.25;
                    }
                    break;
                case "Solothum":

                    //PowerCalcul
                    if (power < 100)
                    {
                        powerCalculated = power * 2;
                    }
                    else
                    {
                        powerCalculated = ((power - 100) * 3) + 200;
                    }

                    //WeightCalcul
                    if (weight < 2000)
                    {
                        weightCalculated = weight * 0.15;
                    }
                    else
                    {
                        weightCalculated = ((weight - 2000) * 0.3) + 300;
                    }

                    //CostYear calcul
                    if (co2Emission > 120)
                    {
                        costYear = powerCalculated + weightCalculated + 40;
                    }
                    else
                    {
                        costYear = (powerCalculated + weightCalculated + 40) * 0.25;
                    }
                    break;
                case "St Gallen":

                    //PowerCalcul
                    if (power < 100)
                    {
                        powerCalculated = power * 2;
                    }
                    else
                    {
                        powerCalculated = ((power - 100) * 3) + 200;
                    }

                    //WeightCalcul
                    if (weight < 2000)
                    {
                        weightCalculated = weight * 0.15;
                    }
                    else
                    {
                        weightCalculated = ((weight - 2000) * 0.3) + 300;
                    }

                    //CostYear calcul
                    if (co2Emission > 120)
                    {
                        costYear = powerCalculated + weightCalculated + 40;
                    }
                    else
                    {
                        costYear = (powerCalculated + weightCalculated + 40) * 0.25;
                    }
                    break;
                case "Thurgau":

                    //PowerCalcul
                    if (power < 100)
                    {
                        powerCalculated = power * 2;
                    }
                    else
                    {
                        powerCalculated = ((power - 100) * 3) + 200;
                    }

                    //WeightCalcul
                    if (weight < 2000)
                    {
                        weightCalculated = weight * 0.15;
                    }
                    else
                    {
                        weightCalculated = ((weight - 2000) * 0.3) + 300;
                    }

                    //CostYear calcul
                    if (co2Emission > 120)
                    {
                        costYear = powerCalculated + weightCalculated + 40;
                    }
                    else
                    {
                        costYear = (powerCalculated + weightCalculated + 40) * 0.25;
                    }
                    break;
                case "Ticino":

                    //PowerCalcul
                    if (power < 100)
                    {
                        powerCalculated = power * 2;
                    }
                    else
                    {
                        powerCalculated = ((power - 100) * 3) + 200;
                    }

                    //WeightCalcul
                    if (weight < 2000)
                    {
                        weightCalculated = weight * 0.15;
                    }
                    else
                    {
                        weightCalculated = ((weight - 2000) * 0.3) + 300;
                    }

                    //CostYear calcul
                    if (co2Emission > 120)
                    {
                        costYear = powerCalculated + weightCalculated + 40;
                    }
                    else
                    {
                        costYear = (powerCalculated + weightCalculated + 40) * 0.25;
                    }
                    break;
                case "Uri":

                    //PowerCalcul
                    if (power < 100)
                    {
                        powerCalculated = power * 2;
                    }
                    else
                    {
                        powerCalculated = ((power - 100) * 3) + 200;
                    }

                    //WeightCalcul
                    if (weight < 2000)
                    {
                        weightCalculated = weight * 0.15;
                    }
                    else
                    {
                        weightCalculated = ((weight - 2000) * 0.3) + 300;
                    }

                    //CostYear calcul
                    if (co2Emission > 120)
                    {
                        costYear = powerCalculated + weightCalculated + 40;
                    }
                    else
                    {
                        costYear = (powerCalculated + weightCalculated + 40) * 0.25;
                    }
                    break;
                case "Valais":

                    //PowerCalcul
                    if (power < 100)
                    {
                        powerCalculated = power * 2;
                    }
                    else
                    {
                        powerCalculated = ((power - 100) * 3) + 200;
                    }

                    //WeightCalcul
                    if (weight < 2000)
                    {
                        weightCalculated = weight * 0.15;
                    }
                    else
                    {
                        weightCalculated = ((weight - 2000) * 0.3) + 300;
                    }

                    //CostYear calcul
                    if (co2Emission > 120)
                    {
                        costYear = powerCalculated + weightCalculated + 40;
                    }
                    else
                    {
                        costYear = (powerCalculated + weightCalculated + 40) * 0.25;
                    }
                    break;
                case "Zug":

                    //PowerCalcul
                    if (power < 100)
                    {
                        powerCalculated = power * 2;
                    }
                    else
                    {
                        powerCalculated = ((power - 100) * 3) + 200;
                    }

                    //WeightCalcul
                    if (weight < 2000)
                    {
                        weightCalculated = weight * 0.15;
                    }
                    else
                    {
                        weightCalculated = ((weight - 2000) * 0.3) + 300;
                    }

                    //CostYear calcul
                    if (co2Emission > 120)
                    {
                        costYear = powerCalculated + weightCalculated + 40;
                    }
                    else
                    {
                        costYear = (powerCalculated + weightCalculated + 40) * 0.25;
                    }
                    break;
                case "Zurich":

                    //PowerCalcul
                    if (power < 100)
                    {
                        powerCalculated = power * 2;
                    }
                    else
                    {
                        powerCalculated = ((power - 100) * 3) + 200;
                    }

                    //WeightCalcul
                    if (weight < 2000)
                    {
                        weightCalculated = weight * 0.15;
                    }
                    else
                    {
                        weightCalculated = ((weight - 2000) * 0.3) + 300;
                    }

                    //CostYear calcul
                    if (co2Emission > 120)
                    {
                        costYear = powerCalculated + weightCalculated + 40;
                    }
                    else
                    {
                        costYear = (powerCalculated + weightCalculated + 40) * 0.25;
                    }
                    break;
                default:

                    //PowerCalcul
                    if (power < 100)
                    {
                        powerCalculated = power * 2;
                    }
                    else
                    {
                        powerCalculated = ((power - 100) * 3) + 200;
                    }

                    //WeightCalcul
                    if (weight < 2000)
                    {
                        weightCalculated = weight * 0.15;
                    }
                    else
                    {
                        weightCalculated = ((weight - 2000) * 0.3) + 300;
                    }

                    //CostYear calcul
                    if (co2Emission > 120)
                    {
                        costYear = powerCalculated + weightCalculated + 40;
                    }
                    else
                    {
                        costYear = (powerCalculated + weightCalculated + 40) * 0.25;
                    }
                    break;
            }
            return costYear;
        }

        public double CalculEssentialMaintain(double insuranceYear, double tiresYear, double revisionYear)
        {
            double costYear = 0;

            costYear = insuranceYear + tiresYear + revisionYear;

            return costYear;
        }

        public double CalculInitialPrice(double purchasePrice, double lifeTime)
        {
            double costYear = 0;

            costYear = purchasePrice / lifeTime;

            return costYear;
        }

        public double CalculConsommation(double fuelPrice, double consomation, double distanceMonth)
        {
            double costYear = 0;

            costYear = (distanceMonth * 12 / 100) * consomation * fuelPrice;

            return costYear;
        }

        public double CalculFuelPrice(string fuel)
        {
            double priceFuel = 0;

            switch(fuel)
            {
                case "95":
                        priceFuel = 1.46;
                        break;
                case "98":
                        priceFuel = 1.55;
                        break;
                case "Diesel":
                        priceFuel = 1.63;
                        break;
                default:
                        priceFuel = 1.46;
                        break;
            }
            return priceFuel;
        }
    }
}