using Common.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBBroker
{
    public class Broker
    {
        private DbConnection connection;
        public Broker()
        {
            connection = new DbConnection();
        }

        public void Rollback()
        {
            connection.Rollback();
        }

        public void Commit()
        {
            connection.Commit();
        }

        public void BeginTransaction()
        {
            connection.BeginTransaction();
        }

        public void CloseConnection()
        {
            connection.CloseConnection();
        }

        public void OpenConnection()
        {
            connection.OpenConnection();
        }

        public Admin Login(Admin user)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"select * from Admin where korisnicko_ime = '{user.KorisnickoIme}' and lozinka = '{user.Lozinka}'";
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                if(reader.Read())
                {
                    user.Prezime = (string)reader["prezime"];
                    user.Ime = (string)reader["ime"];
                    user.Id = (int)reader["id"];
                    return user;
                }
            }
            finally
            {
                reader.Close();
            }
            return null;
        }

    }
}
