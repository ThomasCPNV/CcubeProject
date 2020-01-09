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

        public int GetIdUser(string email)
        {
            int idUser = 0;

            // Create a command object
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"select ID from `user` where email = '{email}'";

            DbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                //we go through the result of the select, we might get only one response. 
                //Despite this, we use a while
                while (reader.Read())
                {
                    idUser = reader.GetInt32(0);
                }
                reader.Close();
            }

            return idUser;
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

        public void InsertIdLicensePlate(string email)
        {
            OpenConnection();

            // Create a SQL command
            MySqlCommand cmd = connection.CreateCommand();

            int idUser = GetIdUser(email);
            int idLicensePlate = GetIdLicensePlate();

            // SQL request
            cmd.CommandText = $"update `License-Plate` SET `iduser` = {idUser} where id = {idLicensePlate}";

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

        public void InsertIdEssentialMaintain(string email)
        {
            OpenConnection();

            // Create a SQL command
            MySqlCommand cmd = connection.CreateCommand();

            int idUser = GetIdUser(email);
            int idEssentialMaintain = GetIdEssentialMaintain();

            // SQL request
            cmd.CommandText = $"update `Essential-Maintain` SET `iduser` = {idUser} where id = {idEssentialMaintain}";

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

        public void InsertIdIntialPrice(string email)
        {
            OpenConnection();

            // Create a SQL command
            MySqlCommand cmd = connection.CreateCommand();

            int idUser = GetIdUser(email);
            int idInitialPrice = GetIdInitialPrice();

            // SQL request
            cmd.CommandText = $"update `Initial-Price` SET `iduser` = {idUser} where id = {idInitialPrice}";

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

        public void InsertIdConsommation(string email)
        {
            OpenConnection();

            // Create a SQL command
            MySqlCommand cmd = connection.CreateCommand();

            int idUser = GetIdUser(email);
            int idConsommation = GetIdConsommation();

            // SQL request
            cmd.CommandText = $"update `Consommation` SET `iduser` = {idUser} where id = {idConsommation}";

            // Execute the SQL command
            cmd.ExecuteNonQuery();

            CloseConnection();
        }
    }
}