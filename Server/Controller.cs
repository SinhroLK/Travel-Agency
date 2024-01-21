using Common.Domain;
using DBBroker;
using Server.SystemOperation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Controller
    {
        private Broker broker;

        private static Controller instance;
        public static Controller Instance
        {
            get
            {
                if (instance == null) instance = new Controller();
                return instance;
            }
        }
        private Controller() { broker = new Broker(); }

        internal object Login(Admin admin)
        {
            LoginSO so = new LoginSO(admin);
            so.ExecuteTemplate();
            return so.Result;
        }

        internal List<Mesto> VratiMesta()
        {
            try
            {
                broker.OpenConnection();
                return broker.VratiMesta();
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        internal object KreirajMesto(Mesto argument)
        {
            DodajMestoSO dodajMesto = new DodajMestoSO(argument);
            dodajMesto.ExecuteTemplate();
            return dodajMesto.Result;
        }
    }
}
