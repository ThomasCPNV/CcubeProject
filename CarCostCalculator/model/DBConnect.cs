using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class DBConnect
    {
        private MySqlConnection connection;

        public DBConnect()
        {
            InitConnection();
        }

        /// <summary>
        /// Initialize the connection to the database
        /// </summary>
        private void InitConnection()
        {
            // Creation of the connection string : where, who
            // Avoid user id and pwd hardcoded
            string connectionString = "SERVER=127.0.0.1; DATABASE=carcostcalculator; UID=userCarCostCalculatorSQL; PASSWORD=Pa$$w0rd";
            connection = new MySqlConnection(connectionString);
        }

        /// <summary>
        /// Open connection to the database
        /// </summary>
        public void OpenConnection()
        {
            connection.Open();
        }

        /// <summary>
        /// add a player in the table "players"
        /// </summary>
        /// <param name="pseudo"></param>
        public void InsertUser(string email, string passwordHashed)
        {
            OpenConnection();
           
            // Create a SQL command
            MySqlCommand cmd = connection.CreateCommand();

            // SQL request
            cmd.CommandText = $"insert into user (email, password) values ('{email}', '{passwordHashed}')";

            // use of the pseudo string, parameter of the method AddPlayer
            cmd.Parameters.AddWithValue("@email", email);

            // Execute the SQL command
            cmd.ExecuteNonQuery();

            CloseConnection();
        }

        /// <summary>
        /// get the name of the player according to his id
        /// </summary>
        /// <param name="id">id of the player</param>
        /// <returns></returns>
        public string GetPasswordUser(string email)
        {
            string passwordUser = "";
          
             OpenConnection();

            // Create a command object
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"select password from user where email = '{email}'";

            DbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                //we go through the result of the select, we might get only one response. 
                //Despite this, we use a while
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

        public string GetEmailUser(string email)
        {
            string emailUser = "";

            OpenConnection();

            // Create a command object
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"select email from user where email = '{email}'";

            DbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                //we go through the result of the select, we might get only one response. 
                //Despite this, we use a while
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

        public bool VerifyEmailAlreadyExist(string email)
        {
            OpenConnection();
            
            // Create a command object
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"select email from user where email = '{email}'";

            DbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                //we go through the result of the select, we might get only one response. 
                //Despite this, we use a while
                reader.Close();
                return true;
            }

            CloseConnection();

            return false;
        }

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
        /// Close connection to the database
        /// </summary>
        public void CloseConnection()
        {
            connection.Dispose();
        }

        public bool InsertLicensePlate(string canton, double power, double weight, double co2Emission, double costYear)
        {
            bool insertLicensePlate = true;

            OpenConnection();

            // Create a SQL command
            MySqlCommand cmd = connection.CreateCommand();

            // SQL request
            cmd.CommandText = $"insert into `license-plate` (`CANTON`, `POWER`, `WEIGHT`, `CO2-EMISSION`, `COST/YEAR`) values ('{canton}', {power}, {weight}, {co2Emission}, {costYear})";

            // Execute the SQL command
            if(cmd.ExecuteNonQuery() == 0)
            {
                insertLicensePlate = false;
            }
            CloseConnection();

            return insertLicensePlate;
        }

        public bool InsertEssentialMaintain(double insuranceYear, double tiresYear, double revisionYear, double costYear)
        {
            bool insertEssentialMaintain = true;

            OpenConnection();

            // Create a SQL command
            MySqlCommand cmd = connection.CreateCommand();

            // SQL request
            cmd.CommandText = $"insert into `essential-maintain` (`INSURANCE/YEAR`, `TIRES/YEAR`, `REVISION/YEAR`, `COST/YEAR`) values ({insuranceYear}, {tiresYear}, {revisionYear}, {costYear})";

            // Execute the SQL command
            if(cmd.ExecuteNonQuery() == 0)
            {
                insertEssentialMaintain = false;
            }
            CloseConnection();

            return insertEssentialMaintain;
        }

        public bool InsertInitialCarPrice(double purchasePrice, double lifeTime, double costYear)
        {
            bool insertInitialCarPrice = true;

            OpenConnection();

            // Create a SQL command
            MySqlCommand cmd = connection.CreateCommand();

            // SQL request
            cmd.CommandText = $"insert into `initial-price` (`PURCHASE-PRICE`, `LIFETIME`, `COST/YEAR`) values ({purchasePrice}, {lifeTime}, {costYear})";

            // Execute the SQL command
            if(cmd.ExecuteNonQuery() == 0)
            {
                insertInitialCarPrice = false;
            }
            CloseConnection();

            return insertInitialCarPrice;
        }

        public bool InsertConsommation(string fuel, double consomation, double distanceMonth, double costYear)
        {
            bool insertConsommation = true;

            OpenConnection();

            // Create a SQL command
            MySqlCommand cmd = connection.CreateCommand();

            // SQL request
            cmd.CommandText = $"insert into `consommation` (`FUEL`, `CONSOMMATION/100km`, `DISTANCE/MONTH`, `COST/YEAR`) values ('{fuel}', {consomation}, {distanceMonth}, {costYear})";

            // Execute the SQL command
            if(cmd.ExecuteNonQuery() == 0)
            {
                insertConsommation = false;
            }
            CloseConnection();

            return insertConsommation;
        }

        public bool InsertCar(string brand, string model, string version, string type, int release)
        {
            bool insertCar = true;

            OpenConnection();

            // Create a SQL command
            MySqlCommand cmd = connection.CreateCommand();

            // SQL request
            cmd.CommandText = $"insert into `car` (`BRAND`, `MODEL`, `VERSION`, `TYPE`, `RELEASE`, `IDLICENSE`, `IDESSENTIAL`, `IDINITIAL`, `IDCONSOMMATION`, `IDUSER`) values ('{brand}', '{model}', '{version}', '{type}', {release}, null, null, null, null, null)";

            // Execute the SQL command
            if (cmd.ExecuteNonQuery() == 0)
            {
                insertCar = false;
            }
            CloseConnection();

            return insertCar;
        }

        public int GetIdUser(string email)
        {
            int idLicensePlate = 0;

            // Create a command object
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"select ID from `USER` where `email` = '{email}'";

            DbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                //we go through the result of the select, we might get only one response. 
                //Despite this, we use a while
                while (reader.Read())
                {
                    idLicensePlate = reader.GetInt32(0);
                }
                reader.Close();
            }
            return idLicensePlate;
        }

        public void InsertIdUser(string email)
        {
            OpenConnection();
            int idUser = GetIdUser(email);

            // Create a SQL command
            MySqlCommand cmd = connection.CreateCommand();

            // SQL request
            cmd.CommandText = $"update `car` SET `IDUSER` = {idUser}";

            // Execute the SQL command
            cmd.ExecuteNonQuery();

            CloseConnection();
        }

        public int GetIdLicensePlate()
        {
            int idLicensePlate = 0;

            // Create a command object
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"select ID from `License-Plate` ORDER BY id ASC";

            DbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                //we go through the result of the select, we might get only one response. 
                //Despite this, we use a while
                while (reader.Read())
                {
                    idLicensePlate = reader.GetInt32(0);
                }
                reader.Close();
            }
            return idLicensePlate;
        }

        public void InsertIdLicensePlate()
        {
            OpenConnection();

            // Create a SQL command
            MySqlCommand cmd = connection.CreateCommand();

            int idLicensePlate = GetIdLicensePlate();

            // SQL request
            cmd.CommandText = $"update `car` SET `IDLICENSE` = {idLicensePlate}";

            // Execute the SQL command
            cmd.ExecuteNonQuery();

            CloseConnection();
        }

        public int GetIdEssentialMaintain()
        {
            int idEssentialMaintain = 0;

            // Create a command object
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"select ID from `Essential-Maintain` ORDER BY id ASC";

            DbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                //we go through the result of the select, we might get only one response. 
                //Despite this, we use a while
                while (reader.Read())
                {
                    idEssentialMaintain = reader.GetInt32(0);
                }
                reader.Close();
            }
            return idEssentialMaintain;
        }

        public void InsertIdEssentialMaintain()
        {
            OpenConnection();

            // Create a SQL command
            MySqlCommand cmd = connection.CreateCommand();

            int idEssentialMaintain = GetIdEssentialMaintain();

            // SQL request
            cmd.CommandText = $"update `Essential-Maintain` SET `IDESSENTIAL` = {idEssentialMaintain}";

            // Execute the SQL command
            cmd.ExecuteNonQuery();

            CloseConnection();
        }

        public int GetIdInitialPrice()
        {
            int idInitialPrice = 0;

            // Create a command object
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"select ID from `Initial-Price` ORDER BY id ASC";

            DbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                //we go through the result of the select, we might get only one response. 
                //Despite this, we use a while
                while (reader.Read())
                {
                    idInitialPrice = reader.GetInt32(0);
                }
                reader.Close();
            }
            return idInitialPrice;
        }

        public void InsertIdIntialPrice()
        {
            OpenConnection();

            // Create a SQL command
            MySqlCommand cmd = connection.CreateCommand();

            int idInitialPrice = GetIdInitialPrice();

            // SQL request
            cmd.CommandText = $"update `Initial-Price` SET `IDINITIAL` = {idInitialPrice}";

            // Execute the SQL command
            cmd.ExecuteNonQuery();

            CloseConnection();
        }

        public int GetIdConsommation()
        {
            int idConsommation = 0;

            // Create a command object
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"select ID from `Consommation` ORDER BY id ASC";

            DbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                //we go through the result of the select, we might get only one response. 
                //Despite this, we use a while
                while (reader.Read())
                {
                    idConsommation = reader.GetInt32(0);
                }
                reader.Close();
            }
            return idConsommation;
        }

        public void InsertIdConsommation()
        {
            OpenConnection();

            // Create a SQL command
            MySqlCommand cmd = connection.CreateCommand();

            int idConsommation = GetIdConsommation();

            // SQL request
            cmd.CommandText = $"update `Consommation` SET `IDCONSOMMATION` = {idConsommation}";

            // Execute the SQL command
            cmd.ExecuteNonQuery();

            CloseConnection();
        }

        public int GetIdUserLicense(string email)
        {
            int idUserLicense = 0;
            int idUser = GetIdUser(email);

            // Create a command object
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"select `IDLICENSE` from `CAR` where `IDUSER` = {idUser}";

            DbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                //we go through the result of the select, we might get only one response. 
                //Despite this, we use a while
                while (reader.Read())
                {
                    idUserLicense = reader.GetInt32(0);
                }
                reader.Close();
            }
            return idUserLicense;
        }

        public List<string> GetLicensePlate(string email)
        {
            OpenConnection();

            List<string> licensePlate = null;
            int idUserLicensePlate = GetIdUserLicense(email);

            // Create a command object
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"select `ID`, `CANTON`, `POWER`, `WEIGHT`, `CO2-EMISSION`, `COST/YEAR` from `license-plate` where `ID` = {idUserLicensePlate}";

            DbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                //we go through the result of the select, we might get only one response. 
                //Despite this, we use a while

                while (reader.Read())
                {
                    licensePlate.Add(reader.GetString(0));
                }
                reader.Close();
            }
            CloseConnection();

            return licensePlate;
        }

        public int GetIdUserEssential(string email)
        {
            int idUserEssential = 0;
            int idUser = GetIdUser(email);

            // Create a command object
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"select `IDESSENTIAL` from `CAR` where `IDUSER` = {idUser}";

            DbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                //we go through the result of the select, we might get only one response. 
                //Despite this, we use a while
                while (reader.Read())
                {
                    idUserEssential = reader.GetInt32(0);
                }
                reader.Close();
            }
            return idUserEssential;
        }

        public List<string> GetEssentialMaintain(string email)
        {
            OpenConnection();

            List<string> essentialMaintain = null;
            int idUserEssential = GetIdUserEssential(email);

            // Create a command object
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"select `ID`, `INSURANCE/YEAR`, `TIRES/YEAR`, `REVISION/YEAR`, `COST/YEAR` from `essential-maintain` where `ID` = '{idUserEssential}'";

            DbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                //we go through the result of the select, we might get only one response. 
                //Despite this, we use a while
                while (reader.Read())
                {
                    essentialMaintain.Add(reader.GetString(0));
                }
                reader.Close();
            }
            CloseConnection();

            return essentialMaintain;
        }

        public int GetIdUserInitial(string email)
        {
            int idUserInitial = 0;
            int idUser = GetIdUser(email);

            // Create a command object
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"select `IDINITIAL` from `CAR` where `IDUSER` = {idUser}";

            DbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                //we go through the result of the select, we might get only one response. 
                //Despite this, we use a while
                while (reader.Read())
                {
                    idUserInitial = reader.GetInt32(0);
                }
                reader.Close();
            }
            return idUserInitial;
        }

        public List<string> GetInitialPrice(string email)
        {
            OpenConnection();

            List<string> initialPrice = null;
            int idUserInitial = GetIdUserInitial(email);

            // Create a command object
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"select `ID`, `PURCHASE-PRICE`, `LIFETIME`, `COST/YEAR` from `initial-price` where `IDUSER` = '{idUserInitial}'";

            DbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                //we go through the result of the select, we might get only one response. 
                //Despite this, we use a while
                while (reader.Read())
                {
                    initialPrice.Add(reader.GetString(0));
                }
                reader.Close();
            }
            CloseConnection();

            return initialPrice;
        }

        public int GetIdUserConsommation(string email)
        {
            int idUserConsommation = 0;
            int idUser = GetIdUser(email);

            // Create a command object
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"select `IDCONSOMMATION` from `CAR` where `IDUSER` = {idUser}";

            DbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                //we go through the result of the select, we might get only one response. 
                //Despite this, we use a while
                while (reader.Read())
                {
                    idUserConsommation = reader.GetInt32(0);
                }
                reader.Close();
            }
            return idUserConsommation;
        }

        public List<string> GetConsommation(string email)
        {
            OpenConnection();

            List<string> consommation = null;
            int idUserConsommation = GetIdUserConsommation(email);

            // Create a command object
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"select `ID`, `FUEL`, `FUEL-PRICE/LITER`, `CONSOMMATION/100km`, `DISTANCE/MONTH`, `COST/YEAR` from `consommation` where `ID` = '{idUserConsommation}'";

            DbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                //we go through the result of the select, we might get only one response. 
                //Despite this, we use a while
                while (reader.Read())
                {
                    consommation.Add(reader.GetString(0));
                }
                reader.Close();
            }
            CloseConnection();

            return consommation;
        }

        public List<string> GetCar(string email)
        {
            OpenConnection();

            List<string> car = null;
            int idUser = GetIdUser(email);

            // Create a command object
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"select `ID`, `BRAND`, `MODEL`, `VERSION`, `TYPE`, `RELEASE` from `CAR` where `IDUSER` = '{idUser}'";

            DbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                //we go through the result of the select, we might get only one response. 
                //Despite this, we use a while
                while (reader.Read())
                {
                    car.Add(reader.GetString(0));
                }
                reader.Close();
            }
            CloseConnection();

            return car;
        }
    }
}