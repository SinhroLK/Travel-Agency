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

        public List<Mesto> VratiMesta()
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "select * from Mesto";
            List<Mesto> list = new List<Mesto>();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Mesto mesto = new Mesto()
                {
                    NazivMesta = (string)reader["naziv"],
                    Valuta = (string)reader["valuta"],
                    BrojStanovnika = (int)reader["broj_stanovnika"]     
                };
                list.Add(mesto);
            }
            reader.Close();
            return list;
        }

        public object KreirajMesto(Mesto m)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"insert into {m.TableName} values({m.Values})";
            if(command.ExecuteNonQuery() > 0)
            {
                return m;
            }
            command.Dispose();
            return null;
        }
    }
}
