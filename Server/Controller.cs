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
            bool postoji = false;
            foreach (ClientHandler client in Server.klijenti)
            {
                if (admin.KorisnickoIme == client.username)
                {
                    postoji = true;
                    break;
                }
            }
            if (!postoji)
            {
                LoginSO so = new LoginSO(admin);
                so.ExecuteTemplate();
                return so.Result;
            }
            return null;
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

        internal object KreirajAranzman(Aranzman argument)
        {
            DodajAranzmanSO dodajAranzman = new DodajAranzmanSO(argument);
            dodajAranzman.ExecuteTemplate();
            return dodajAranzman.Result;
        }

        internal object VratiAranzmane(Aranzman argument)
        {
            VratiAranzmaneSO vratiAranzmane = new VratiAranzmaneSO(argument);
            vratiAranzmane.ExecuteTemplate();
            return (List<Aranzman>)vratiAranzmane.Result;
        }

        internal object ObrisiAranzman(Aranzman argument)
        {
            ObrisiAranzmanSO obrisiAranzman= new ObrisiAranzmanSO(argument);
            obrisiAranzman.ExecuteTemplate();
            return obrisiAranzman.Result;
        }

        internal object IzmeniAranzman(Aranzman argument)
        {
            IzmeniAranzmanSO izmeniAranzman = new IzmeniAranzmanSO(argument);
            izmeniAranzman.ExecuteTemplate();
            return izmeniAranzman.Result;
        }

        internal object VratiTermine(Termin argument)
        {
            VratiTermineSO vratiTermine = new VratiTermineSO(argument);
            vratiTermine.ExecuteTemplate();
            return vratiTermine.Result;
        }

        internal object KreirajTermin(Termin argument)
        {
            DodajTerminSO dodajTermin= new DodajTerminSO(argument);
            dodajTermin.ExecuteTemplate();
            return dodajTermin.Result;
        }

        internal object ObrisiTermin(Termin argument)
        {
            ObrisiTerminSO obrisiTermin= new ObrisiTerminSO(argument);
            obrisiTermin.ExecuteTemplate();
            return obrisiTermin.Result;
        }

        internal object IzmeniTermin(Termin argument)
        {
            IzmeniTerminSO izmeniTermin = new IzmeniTerminSO(argument);
            izmeniTermin.ExecuteTemplate();
            return izmeniTermin.Result;
        }

        internal object VratiProlaznaMesta(ProlaznoMesto argument)
        {
            VratiProlaznaMestaSO vratiMesta = new VratiProlaznaMestaSO(argument);
            vratiMesta.ExecuteTemplate();
            return (List<ProlaznoMesto>)vratiMesta.Result;
        }
    }
}
