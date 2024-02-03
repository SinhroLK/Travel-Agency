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
            VratiMestaSO vratiMesta = new VratiMestaSO(mesto);
            vratiMesta.ExecuteTemplate();
            return (List<Mesto>)vratiMesta.Result;
        }
        internal object KreirajMesto(Mesto argument)
        {
            DodajMestoSO dodajMesto = new DodajMestoSO(argument);
            dodajMesto.ExecuteTemplate();
            return dodajMesto.Result;
        }

        internal List<Vodic> VratiVodice(Vodic vodic)
        {
            VratiVodiceSO vratiVodice = new VratiVodiceSO(vodic);
            vratiVodice.ExecuteTemplate();
            return (List<Vodic>)vratiVodice.Result;
        }

        internal object KreirajVodica(Vodic argument)
        {
            DodajVodicaSO dodajVodica = new DodajVodicaSO(argument);
            dodajVodica.ExecuteTemplate();
            return dodajVodica.Result;
        }

        internal object ObrisiVodica(Vodic argument)
        {
            ObrisiVodicaSO obrisiVodica = new ObrisiVodicaSO(argument);
            obrisiVodica.ExecuteTemplate();
            return obrisiVodica.Result;
        }

        internal object KreirajSadrzaj(Sadrzaj argument)
        {
            DodajSadrzajSO dodajSadrzaj = new DodajSadrzajSO(argument);
            dodajSadrzaj.ExecuteTemplate();
            return dodajSadrzaj.Result;
        }
    }
}
