﻿/*
 * Developer : Thomas Huguet
 * Project : CarCostCalculator
 * Version : 1.0
 * Creation date : 19.12.2019 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    /// <summary>
    /// this is used for all datas's handling
    /// </summary>
    public class DataManager
    {
        private DBConnect dbConnect = new DBConnect();

        /// <summary>
        /// Calcul the cost/year of LicensePlate
        /// </summary>
        /// <param name="canton">contain the canton filled by the user</param>
        /// <param name="power">contain the power filled by the user</param>
        /// <param name="formatPower">contain the format of power filled by the user</param>
        /// <param name="weight">contain the weight filled by the user</param>
        /// <param name="co2Emission">contain the co2 emission filled by the user</param>
        /// <returns>return the cost/year of LicensePlate</returns>
        public double CalculLicensePlate(string canton, double power, string formatPower, double weight, double co2Emission)
        {
            double costYear = 0;
            double powerCalculated;
            double weightCalculated;

            if (formatPower == "hp")
            {
                power = power * 0.74;
            }

            //All there numbers used can be finded on the excel "Voiture" file in the "Documentation" repertory
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

        /// <summary>
        /// Calcul the cost/year of EssentialMaintain
        /// </summary>
        /// <param name="insuranceYear">contain insurance/year filled by the user</param>
        /// <param name="tiresYear">contain the tires/year filled by the user</param>
        /// <param name="revisionYear">contain the revision/year filled by the user</param>
        /// <returns>return the cost/year of EssentialMaintain</returns>
        public double CalculEssentialMaintain(double insuranceYear, double tiresYear, double revisionYear)
        {
            double costYear = 0;

            costYear = insuranceYear + tiresYear + revisionYear;

            return costYear;
        }

        /// <summary>
        /// Calcul the cost/year of InitialPrice
        /// </summary>
        /// <param name="purchasePrice">contain the purchase price filled by the user</param>
        /// <param name="lifeTime">contain the life time filled by the user</param>
        /// <returns></returns>
        public double CalculInitialPrice(double purchasePrice, double lifeTime)
        {
            double costYear = 0;

            costYear = purchasePrice / lifeTime;

            return costYear;
        }

        /// <summary>
        /// Calcul the cost/year of Consommation
        /// </summary>
        /// <param name="fuel">contain the fuel name selected</param>
        /// <param name="consomation">contain the consommation filled by the user</param>
        /// <param name="distanceMonth">contain the distance/month filled by the user</param>
        /// <returns>return the cost/year of Consommation</returns>
        public double CalculConsommation(string fuel, double consomation, double distanceMonth)
        {
            double costYear = 0;
            double fuelPrice = CalculFuelPrice(fuel);

            costYear = (distanceMonth * 12 / 100) * consomation * fuelPrice;

            return costYear;
        }

        /// <summary>
        /// Calcul the price of fuel selected by the user
        /// </summary>
        /// <param name="fuel">contain the fuel name slected</param>
        /// <returns>return the price of the fuel selected</returns>
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