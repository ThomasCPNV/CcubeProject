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
            string connectionString = "SERVER=127.0.0.1; DATABASE=CcubeProject; UID=root; PASSWORD=Pa$$w0rd";
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
            try
            {
                OpenConnection();
            }
            catch
            {
                throw new Exception("Impossible de se connecter à la base de données !");
            }
           
            // Create a SQL command
            MySqlCommand cmd = connection.CreateCommand();

            // SQL request
            cmd.CommandText = $"insert into users (email, password, type) values ('{email}', '{passwordHashed}',{1})";

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

            try
            {
                OpenConnection();
            }
            catch
            {
                throw new Exception("Impossible de se connecter à la base de données !");
            }

            // Create a command object
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = $"select password from users where email = '{email}'";

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


        /// <summary>
        /// Close connection to the database
        /// </summary>
        public void CloseConnection()
        {
            connection.Dispose();
        }
    }
}
