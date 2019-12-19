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

        public bool InsertLicensePlate(string canton, double power, double weight, double co2Emission, double costYear, double costMonth)
        {
            bool insertLicensePlate = true;

            OpenConnection();

            // Create a SQL command
            MySqlCommand cmd = connection.CreateCommand();

            // SQL request
            cmd.CommandText = $"insert into license-plate (CANTON, POWER, WEIGHT, CO2-EMISSION, COST/YEAR, COST/MONTH) values ('{canton}', {power}, {weight}, {co2Emission}, {costYear}, {costMonth})";

            // Execute the SQL command
            if(cmd.ExecuteNonQuery() == 0)
            {
                insertLicensePlate = false;
            }

            CloseConnection();

            return insertLicensePlate;
        }

        public bool InsertEssentialMaintain(double insuranceYear, double tiresYear, double revisionYear, double costYear, double costMonth)
        {
            bool insertEssentialMaintain = true;

            OpenConnection();

            // Create a SQL command
            MySqlCommand cmd = connection.CreateCommand();

            // SQL request
            cmd.CommandText = $"insert into essential-maintain (INSURANCE/YEAR, TIRES/YEAR, REVISION/YEAR, COST/YEAR, COST/MONTH) values ({insuranceYear}, {tiresYear}, {revisionYear}, {costYear}, {costMonth})";

            // Execute the SQL command
            if(cmd.ExecuteNonQuery() == 0)
            {
                insertEssentialMaintain = false;
            }

            CloseConnection();

            return insertEssentialMaintain;
        }

        public bool InsertInitialCarPrice(double purchasePrice, double lifeTime, double costYear, double costMonth)
        {
            bool insertInitialCarPrice = true;

            OpenConnection();

            // Create a SQL command
            MySqlCommand cmd = connection.CreateCommand();

            // SQL request
            cmd.CommandText = $"insert into initial-price (PURCHASE-PRICE, LIFETIME, COST/YEAR, COST/MONTH) values ({purchasePrice}, {lifeTime}, {costYear}, {costMonth})";

            // Execute the SQL command
            if(cmd.ExecuteNonQuery() == 0)
            {
                insertInitialCarPrice = false;
            }

            CloseConnection();

            return insertInitialCarPrice;
        }

        public bool InsertConsommation(string fuel, double fuelPrice, double consomation, double distanceMonth, double costYear, double costMonth)
        {
            bool insertConsommation = true;

            OpenConnection();

            // Create a SQL command
            MySqlCommand cmd = connection.CreateCommand();

            // SQL request
            cmd.CommandText = $"insert into consommation (FUEL, FUEL-PRICE/LITER, CONSOMMATION/100km, DISTANCE/MONTH, COST/YEAR, COST/MONTH) values ('{fuel}', {fuelPrice}, {consomation}, {distanceMonth}, {costYear}, {costMonth})";

            // Execute the SQL command
            if(cmd.ExecuteNonQuery() == 0)
            {
                insertConsommation = false;
            }

            CloseConnection();

            return insertConsommation;
        }

        public int GetIdLicensePlate()
        {
            int idLicensePlate = 0;
            int i = 0;

            OpenConnection();

            // Create a command object
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"select ID from license-plate";

            DbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                //we go through the result of the select, we might get only one response. 
                //Despite this, we use a while
                while (reader.Read())
                {
                    i++;
                    idLicensePlate = reader.GetInt32(i);
                }
                reader.Close();
            }

            CloseConnection();

            return idLicensePlate;
        }

        public void InsertIdLicensePlate(string email)
        {
            OpenConnection();

            // Create a SQL command
            MySqlCommand cmd = connection.CreateCommand();

            int idLicensePlate = GetIdLicensePlate();

            // SQL request
            cmd.CommandText = $"insert into user (License-Plate) values ({idLicensePlate}) where email = '{email}'";

            // Execute the SQL command
            cmd.ExecuteNonQuery();

            CloseConnection();
        }

        public int GetIdEssentialMaintain()
        {
            int idEssentialMaintain = 0;
            int i = 0;

            OpenConnection();

            // Create a command object
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"select ID from essential-maintain";

            DbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                //we go through the result of the select, we might get only one response. 
                //Despite this, we use a while
                while (reader.Read())
                {
                    i++;
                    idEssentialMaintain = reader.GetInt32(i);
                }
                reader.Close();
            }

            CloseConnection();

            return idEssentialMaintain;
        }

        public void InsertIdEssentialMaintain(string email)
        {
            OpenConnection();

            // Create a SQL command
            MySqlCommand cmd = connection.CreateCommand();

            int idEssentialMaintain = GetIdEssentialMaintain();

            // SQL request
            cmd.CommandText = $"insert into user (ESSENTIAL-MAINTAIN) values ({idEssentialMaintain}) where email = '{email}'";

            // Execute the SQL command
            cmd.ExecuteNonQuery();

            CloseConnection();
        }

        public int GetIdInitialPrice()
        {
            int idInitialPrice = 0;
            int i = 0;

            OpenConnection();

            // Create a command object
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"select ID from initial-price";

            DbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                //we go through the result of the select, we might get only one response. 
                //Despite this, we use a while
                while (reader.Read())
                {
                    i++;
                    idInitialPrice = reader.GetInt32(i);
                }
                reader.Close();
            }

            CloseConnection();

            return idInitialPrice;
        }

        public void InsertIdIntialPrice(string email)
        {
            OpenConnection();

            // Create a SQL command
            MySqlCommand cmd = connection.CreateCommand();

            int idInistialPrice = GetIdInitialPrice();

            // SQL request
            cmd.CommandText = $"insert into user (INITIAL-PRICE) values ({idInistialPrice}) where email = '{email}'";

            // Execute the SQL command
            cmd.ExecuteNonQuery();

            CloseConnection();
        }

        public int GetIdConsommation()
        {
            int idConsommation = 0;
            int i = 0;

            OpenConnection();

            // Create a command object
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"select ID from consommation";

            DbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                //we go through the result of the select, we might get only one response. 
                //Despite this, we use a while
                while (reader.Read())
                {
                    i++;
                    idConsommation = reader.GetInt32(i);
                }
                reader.Close();
            }

            CloseConnection();

            return idConsommation;
        }

        public void InsertIdConsommation(string email)
        {
            OpenConnection();

            // Create a SQL command
            MySqlCommand cmd = connection.CreateCommand();

            int idConsommation = GetIdConsommation();

            // SQL request
            cmd.CommandText = $"insert into user (CONSOMMATION) values ({idConsommation}) where email = '{email}'";

            // Execute the SQL command
            cmd.ExecuteNonQuery();

            CloseConnection();
        }
    }
}