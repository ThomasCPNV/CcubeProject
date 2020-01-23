/*
 * Developer : Thomas Huguet
 * Version : 1.0
 * Creation date : 29.11.2019 
 */

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    /// <summary>
    /// This is used for all the interactions with the DB
    /// </summary>
    public class DBConnect
    {
        private MySqlConnection connection;

        /// <summary>
        /// Initialize the connection to the database
        /// </summary>
        public DBConnect()
        {
            InitConnection();
        }

        /// <summary>
        /// Initialize the connection to the database
        /// </summary>
        private void InitConnection()
        {
            string connectionString = "SERVER=127.0.0.1; DATABASE=carcostcalculator; UID=userCarCostCalculatorSQL; PASSWORD=Pa$$w0rd";
            connection = new MySqlConnection(connectionString);
        }

        /// <summary>
        /// Open the connection to the database
        /// </summary>
        public void OpenConnection()
        {
            connection.Open();
        }

        /// <summary>
        /// Insert the email and the password (hashed) of the user connected in the DB
        /// </summary>
        /// <param name="email">contain the email filled by the user</param>
        /// <param name="passwordHashed">contain the password (hashed) filled by the user</param>
        public void InsertUser(string email, string passwordHashed)
        {
            OpenConnection();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"insert into user (email, password) values ('{email}', '{passwordHashed}')";

            cmd.Parameters.AddWithValue("@email", email);

            cmd.ExecuteNonQuery();

            CloseConnection();
        }

        /// <summary>
        /// Get the password of the user connected
        /// </summary>
        /// <param name="email">contain the email filled by the user</param>
        /// <returns>return the password of the user connected</returns>
        public string GetPasswordUser(string email)
        {
            string passwordUser = "";
          
             OpenConnection();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"select password from user where email = '{email}'";

            DbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    passwordUser = reader.GetString(0);
                }
                reader.Close();
                return passwordUser;
            }

            CloseConnection();

            return passwordUser;
        }

        /// <summary>
        /// Get the email of the user connected
        /// </summary>
        /// <param name="email">contain the email filled by the user</param>
        /// <returns>return the email of the user connected</returns>
        public string GetEmailUser(string email)
        {
            string emailUser = "";

            OpenConnection();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"select email from user where email = '{email}'";

            DbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    emailUser = reader.GetString(0);
                }
                reader.Close();
                return emailUser;
            }

            CloseConnection();

            return emailUser;
        }

        /// <summary>
        /// Verify if the email filled by the user is already in the DB
        /// </summary>
        /// <param name="email">contain the email filled by the user</param>
        /// <returns>return true or false</returns>
        public bool VerifyEmailAlreadyExist(string email)
        {
            OpenConnection();
            
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"select email from user where email = '{email}'";

            DbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Close();
                return true;
            }

            CloseConnection();

            return false;
        }

        /// <summary>
        /// Test the connection to the DB  
        /// </summary>
        /// <returns>return true or false</returns>
        public bool TestConnectionBD()
        {
            try
            {
                OpenConnection();
            }
            catch
            {
                return false;
            }
            CloseConnection();

            return true;
        }

        /// <summary>
        /// Close the connection to the database
        /// </summary>
        public void CloseConnection()
        {
            connection.Dispose();
        }

        /// <summary>
        /// Insert the informations of the License Plate fillded by the user in the DB
        /// </summary>
        /// <param name="canton">contain the canton filled by the user</param>
        /// <param name="power">contain the power of the car filled by the user</param>
        /// <param name="weight">contain the weight filled by the user</param>
        /// <param name="co2Emission">contain the co2 emission filled by the user</param>
        /// <param name="costYear">contain the cost/year calculated by the method "CalculLicensePlate"</param>
        /// <returns>return true or false</returns>
        public bool InsertLicensePlate(string canton, double power, double weight, double co2Emission, double costYear)
        {
            bool insertLicensePlate = true;

            OpenConnection();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"insert into `license-plate` (`CANTON`, `POWER`, `WEIGHT`, `CO2-EMISSION`, `COST/YEAR`) values ('{canton}', {power}, {weight}, {co2Emission}, {costYear})";

            if (cmd.ExecuteNonQuery() == 0)
            {
                insertLicensePlate = false;
            }
            CloseConnection();

            return insertLicensePlate;
        }

        /// <summary>
        /// Insert the informations of the essential maintain filled by the user in the DB
        /// </summary>
        /// <param name="insuranceYear">contain the insurance/year filled by the user</param>
        /// <param name="tiresYear">contain the tires/year filled by the user</param>
        /// <param name="revisionYear">contain the revision/year filled by the user</param>
        /// <param name="costYear">contain the cost/year calculated by the method "CalculEssentialMaintain"</param>
        /// <returns>return true or false</returns>
        public bool InsertEssentialMaintain(double insuranceYear, double tiresYear, double revisionYear, double costYear)
        {
            bool insertEssentialMaintain = true;

            OpenConnection();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"insert into `essential-maintain` (`INSURANCE/YEAR`, `TIRES/YEAR`, `REVISION/YEAR`, `COST/YEAR`) values ({insuranceYear}, {tiresYear}, {revisionYear}, {costYear})";

            if (cmd.ExecuteNonQuery() == 0)
            {
                insertEssentialMaintain = false;
            }
            CloseConnection();

            return insertEssentialMaintain;
        }

        /// <summary>
        /// Insert the informations of the Initial Car Price fillded by the user in the DB
        /// </summary>
        /// <param name="purchasePrice">contain the purchase price filled by the user</param>
        /// <param name="lifeTime">contain the life time of the car filled by the user</param>
        /// <param name="costYear">containt the cost/year calculated by the method "CalculInitialPrice"</param>
        /// <returns>return true or false</returns>
        public bool InsertInitialCarPrice(double purchasePrice, double lifeTime, double costYear)
        {
            bool insertInitialCarPrice = true;

            OpenConnection();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"insert into `initial-price` (`PURCHASE-PRICE`, `LIFETIME`, `COST/YEAR`) values ({purchasePrice}, {lifeTime}, {costYear})";

            if(cmd.ExecuteNonQuery() == 0)
            {
                insertInitialCarPrice = false;
            }
            CloseConnection();

            return insertInitialCarPrice;
        }

        /// <summary>
        /// Insert the informations of the Consommation fillded by the user in the DB
        /// </summary>
        /// <param name="fuel">contain the name of the fuel filled by the user</param>
        /// <param name="consomation">contain the consommation filled by the user</param>
        /// <param name="distanceMonth">contain the distance/month flled by the user</param>
        /// <param name="costYear">contain the cost/year calculated by the method "CalculConsommation"</param>
        /// <returns>return true or false</returns>
        public bool InsertConsommation(string fuel, double consomation, double distanceMonth, double costYear)
        {
            bool insertConsommation = true;

            OpenConnection();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"insert into `consommation` (`FUEL`, `CONSOMMATION/100km`, `DISTANCE/MONTH`, `COST/YEAR`) values ('{fuel}', {consomation}, {distanceMonth}, {costYear})";

            if(cmd.ExecuteNonQuery() == 0)
            {
                insertConsommation = false;
            }
            CloseConnection();

            return insertConsommation;
        }

        /// <summary>
        /// Insert the informations of the Car fillded by the user in the DB
        /// </summary>
        /// <param name="brand">contain the brand filled by the user</param>
        /// <param name="model">contain the model filled by the user</param>
        /// <param name="version">contain the version filled by the user</param>
        /// <param name="type">contain the type filled by the user</param>
        /// <param name="release">contain the release filled by the user</param>
        /// <param name="email">contain the email of the user connected</param>
        /// <returns>return true or false</returns>
        public bool InsertCar(string brand, string model, string version, string type, int release, string email)
        {
            OpenConnection();

            bool insertCar = true;
            int idLicence = GetIdLicensePlate();
            int idEssential = GetIdEssentialMaintain();
            int idInitial = GetIdInitialPrice();
            int idConsommation = GetIdConsommation();
            int idUser = GetIdUser(email);

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"insert into `car` (`BRAND`, `MODEL`, `VERSION`, `TYPE`, `RELEASE`, `IDLICENSE`, `IDESSENTIAL`, `IDINITIAL`, `IDCONSOMMATION`, `IDUSER`) values ('{brand}', '{model}', '{version}', '{type}', {release}, {idLicence}, {idEssential}, {idInitial}, {idConsommation}, {idUser})";

            if (cmd.ExecuteNonQuery() == 0)
            {
                insertCar = false;
            }
            CloseConnection();

            return insertCar;
        }

        /// <summary>
        /// Get the id of the last LicensePlate inserted
        /// </summary>
        /// <returns>return the id of the last LicensePlate</returns>
        public int GetIdLicensePlate()
        {
            int idLicensePlate = 0;

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"select ID from `License-Plate` ORDER BY id ASC";

            DbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    idLicensePlate = reader.GetInt32(0);
                }
                reader.Close();
            }
            return idLicensePlate;
        }

        /// <summary>
        /// Get the id of the last EssentialMaintain inserted
        /// </summary>
        /// <returns>return the id of the last EssentialMaintain inserted</returns>
        public int GetIdEssentialMaintain()
        {
            int idEssentialMaintain = 0;

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"select ID from `Essential-Maintain` ORDER BY id ASC";

            DbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    idEssentialMaintain = reader.GetInt32(0);
                }
                reader.Close();
            }
            return idEssentialMaintain;
        }

        /// <summary>
        /// Get the id of the last InitialPrice inserted
        /// </summary>
        /// <returns>return the id of the last InitialPrice inserted</returns>
        public int GetIdInitialPrice()
        {
            int idInitialPrice = 0;

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"select ID from `Initial-Price` ORDER BY id ASC";

            DbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    idInitialPrice = reader.GetInt32(0);
                }
                reader.Close();
            }
            return idInitialPrice;
        }

        /// <summary>
        /// Get the id of the last Consommation inserted
        /// </summary>
        /// <returns>return the id of the last Consommation inserted</returns>
        public int GetIdConsommation()
        {
            int idConsommation = 0;

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"select ID from `Consommation` ORDER BY id ASC";

            DbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    idConsommation = reader.GetInt32(0);
                }
                reader.Close();
            }
            return idConsommation;
        }

        /// <summary>
        /// Get the id of the user connected
        /// </summary>
        /// <param name="email">contain the email of the user connected</param>
        /// <returns>return the id of the user connected</returns>
        public int GetIdUser(string email)
        {
            int idLicensePlate = 0;

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"select ID from `USER` where `email` = '{email}'";

            DbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    idLicensePlate = reader.GetInt32(0);
                }
                reader.Close();
            }
            return idLicensePlate;
        }

        /// <summary>
        /// Get all id LicensePlate of the user connected
        /// </summary>
        /// <param name="email">contain the email of the user connected</param>
        /// <returns>return an array of all id LicensePlate's user connected</returns>
        public List<int> GetIdUserLicense(string email)
        {
            List<int> idUserLicense = new List<int>();
            int idUser = GetIdUser(email);

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"select `IDLICENSE` from `CAR` where `IDUSER` = {idUser}";

            DbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    idUserLicense.Add(reader.GetInt32(0));
                }
                reader.Close();
            }
            return idUserLicense;
        }

        /// <summary>
        /// Get all LicensePlate's user connected informations
        /// </summary>
        /// <param name="email">contain the user of the user connected</param>
        /// <returns>return an array who has all LicensePlate's user connected informations</returns>
        public List<string> GetLicensePlate(string email)
        {
            OpenConnection();

            List<string> licensePlate = new List<string>();
            List<int> idUserLicensePlate = GetIdUserLicense(email);

            for (int compteurId = 0; compteurId < idUserLicensePlate.Count; compteurId++)
            {
                MySqlCommand cmd = connection.CreateCommand();

                cmd.CommandText = $"select `ID`, `CANTON`, `POWER`, `WEIGHT`, `CO2-EMISSION`, `COST/YEAR` from `license-plate` where `ID` = {idUserLicensePlate[compteurId]}";

                DbDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        for (int compteur = 0; compteur < reader.FieldCount; compteur++)
                        {
                            licensePlate.Add(reader.GetString(compteur));
                        }
                    }
                    reader.Close();
                }
            }
            CloseConnection();

            return licensePlate;
        }

        /// <summary>
        ///  Get all id EssentialMaintain of the user connected
        /// </summary>
        /// <param name="email">contain the email of the user connected</param>
        /// <returns>return an array of all id EssentialMaintain's user connected</returns>
        public List<int> GetIdUserEssential(string email)
        {
            List<int> idUserEssential = new List<int>();
            int idUser = GetIdUser(email);

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"select `IDESSENTIAL` from `CAR` where `IDUSER` = {idUser}";

            DbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    idUserEssential.Add(reader.GetInt32(0));
                }
                reader.Close();
            }
            return idUserEssential;
        }

        /// <summary>
        ///  Get all EssentialMaintain's user connected informations
        /// </summary>
        /// <param name="email">contain the email of the user connected</param>
        /// <returns>return an array who has all EssentialMaintain's user connected informations</returns>
        public List<string> GetEssentialMaintain(string email)
        {
            OpenConnection();

            List<string> essentialMaintain = new List<string>();
            List<int> idUserEssential = GetIdUserEssential(email);

            for (int compteurId = 0; compteurId < idUserEssential.Count; compteurId++)
            {
                MySqlCommand cmd = connection.CreateCommand();

                cmd.CommandText = $"select `ID`, `INSURANCE/YEAR`, `TIRES/YEAR`, `REVISION/YEAR`, `COST/YEAR` from `essential-maintain` where `ID` = '{idUserEssential[compteurId]}'";

                DbDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        for (int compteur = 0; compteur < reader.FieldCount; compteur++)
                        {
                            essentialMaintain.Add(reader.GetString(compteur));
                        }
                    }
                    reader.Close();
                }
            }
            CloseConnection();

            return essentialMaintain;
        }

        /// <summary>
        ///  Get all id InitialPrice of the user conneted
        /// </summary>
        /// <param name="email">contain the email of the user connected</param>
        /// <returns>return an array of all id InitialPrice's user connected</returns>
        public List<int> GetIdUserInitial(string email)
        {
            List<int> idUserInitial = new List<int>();
            int idUser = GetIdUser(email);

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"select `IDINITIAL` from `CAR` where `IDUSER` = {idUser}";

            DbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    idUserInitial.Add(reader.GetInt32(0));
                }
                reader.Close();
            }
            return idUserInitial;
        }

        /// <summary>
        /// Get all InitialPrice's user connected informations
        /// </summary>
        /// <param name="email">contain the email of the user connected</param>
        /// <returns>return an array who has all InitialPrice's user connected informations</returns>
        public List<string> GetInitialPrice(string email)
        {
            OpenConnection();

            List<string> initialPrice = new List<string>();
            List<int> idUserInitial = GetIdUserInitial(email);

            for (int compteurId = 0; compteurId < idUserInitial.Count; compteurId++)
            {
                MySqlCommand cmd = connection.CreateCommand();

                cmd.CommandText = $"select `ID`, `PURCHASE-PRICE`, `LIFETIME`, `COST/YEAR` from `initial-price` where `ID` = '{idUserInitial[compteurId]}'";

                DbDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        for (int compteur = 0; compteur < reader.FieldCount; compteur++)
                        {
                            initialPrice.Add(reader.GetString(compteur));
                        }
                    }
                    reader.Close();
                }
            }
            CloseConnection();

            return initialPrice;
        }

        /// <summary>
        /// Get all id Consommation of the user conneted
        /// </summary>
        /// <param name="email">contian the email of the user connected</param>
        /// <returns>return an array of all id Consommation's user connected</returns>
        public List<int> GetIdUserConsommation(string email)
        {
            List<int> idUserConsommation = new List<int>();
            int idUser = GetIdUser(email);

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"select `IDCONSOMMATION` from `CAR` where `IDUSER` = {idUser}";

            DbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    idUserConsommation.Add(reader.GetInt32(0));
                }
                reader.Close();
            }
            return idUserConsommation;
        }

        /// <summary>
        /// Get all Consommation's user connected informations
        /// </summary>
        /// <param name="email">contain the email of the user connected</param>
        /// <returns>return an array who has all Consommation's user connected informations</returns>
        public List<string> GetConsommation(string email)
        {
            OpenConnection();

            List<string> consommation = new List<string>();
            List<int> idUserConsommation = GetIdUserConsommation(email);

            for (int compteurId = 0; compteurId < idUserConsommation.Count; compteurId++)
            { 
                MySqlCommand cmd = connection.CreateCommand();

                cmd.CommandText = $"select `ID`, `FUEL`, `CONSOMMATION/100km`, `DISTANCE/MONTH`, `COST/YEAR` from `consommation` where `ID` = '{idUserConsommation[compteurId]}'";

                DbDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        for (int compteur = 0; compteur < reader.FieldCount; compteur++)
                        {
                            consommation.Add(reader.GetString(compteur));
                        }
                    }
                    reader.Close();
                }
            }
            CloseConnection();

            return consommation;
        }

        /// <summary>
        /// Get all Car's user connected informations
        /// </summary>
        /// <param name="email">contain the email of the user connected</param>
        /// <returns>return an array who has all Car's user connected informations</returns>
        public List<string> GetCar(string email)
        {
            OpenConnection();

            List<string> car = new List<string>();
            int idUser = GetIdUser(email);

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"select `ID`, `BRAND`, `MODEL`, `VERSION`, `TYPE`, `RELEASE` from `CAR` where `IDUSER` = '{idUser}'";

            DbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    for (int compteur = 0; compteur < reader.FieldCount; compteur++)
                    {
                        car.Add(reader.GetString(compteur));
                    }
                }
                reader.Close();
            }
            CloseConnection();

            return car;
        }
    }
}