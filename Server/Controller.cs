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
        internal List<Mesto> VratiMesta(Mesto mesto)
        {
            try
            {
                broker.OpenConnection();
                return broker.VratiListu(mesto).Select(x => new Mesto() 
                { 
                    MestoId = ((Mesto)x).MestoId,
                    NazivMesta = ((Mesto)x).NazivMesta,
                    Valuta = ((Mesto)x).Valuta,
                    BrojStanovnika = ((Mesto)x).BrojStanovnika

                }).ToList();
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

        internal object VratiVodice(Vodic vodic)
        {
            try
            {
                broker.OpenConnection();
                return broker.VratiListu(vodic).Select(x => new Vodic()
                {
                    VodicId = ((Vodic)x).VodicId,
                    Ime = ((Vodic)x).Ime,
                    Plata = ((Vodic)x).Plata,
                    BrojTelefona = ((Vodic)x).BrojTelefona,
                    DatumRodjenja = ((Vodic)x).DatumRodjenja,
                    DatumIstekaUgovora = ((Vodic)x).DatumIstekaUgovora
                }).ToList();
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        internal object KreirajVodica(Vodic argument)
        {
            DodajVodicaSO dodajVodica = new DodajVodicaSO(argument);
            dodajVodica.ExecuteTemplate();
            return dodajVodica.Result;
        }
    }
}
