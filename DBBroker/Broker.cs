using Common.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
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

        public List<IEntity> VratiSve(IEntity objekat)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"select * from {objekat.TableName} {objekat.zaJoin}";
            List<IEntity> list = new List<IEntity>();
            SqlDataReader reader = command.ExecuteReader();
            list = objekat.VratiReaderListu(reader); 
            reader.Close();
            return list;
        }

        public object Kreiraj(IEntity entity)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"insert into {entity.TableName} values({entity.Values})";
            if(command.ExecuteNonQuery() > 0)
            {
                return entity;
            }
            command.Dispose();
            return null;
        }

        public object Obrisi(IEntity entity)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"delete from {entity.TableName} where {entity.idColumnName} = {entity.id}";
            if (command.ExecuteNonQuery() > 0)
            {
                command.Dispose();
                return entity;
            }
            command.Dispose();
            return null;

        }

        public object Izmeni(IEntity objekat)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"update {objekat.TableName} set {objekat.zaSet} where {objekat.idColumnName} = {objekat.id}";
            if(command.ExecuteNonQuery() > 0)
            {
                command.Dispose();
                return objekat;
            }
            command.Dispose();
            return null;
        }
    }
}
