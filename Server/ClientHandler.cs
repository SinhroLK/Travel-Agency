using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ClientHandler
    {
        private Sender sender;
        private Receiver receiver;
        private Socket socket;
        public string username;

        public ClientHandler(Socket socket)
        {
            this.socket = socket;
            sender = new Sender(socket);
            receiver = new Receiver(socket);
        }

        internal void Close()
        {
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
            socket = null;
        }

        internal void HandleRequest()
        {
            try
            {
                while (true)
                {
                    Request req = (Request)receiver.Receive();
                    if(req == null)
                    {
                        throw new Exception();
                    }
                    Response r = ProcessRequest(req);
                    sender.Send(r);
                }
            }
            catch (Exception se)
            {
                Debug.WriteLine(">>>Ugasio sam server" + se.Message);
            }
        }

        private Response ProcessRequest(Request req)
        {
            Response r = new Response();
            try
            {
                switch (req.Operation)
                {
                    case Operation.Login:
                        r.Odgovor = Controller.Instance.Login((Admin)req.Argument);
                        if (r.Odgovor == null)
                        {
                            throw new Exception();
                        }
                        else
                        {
                            Admin a = r.Odgovor as Admin;
                            username = a.KorisnickoIme; 
                        }
                        break;
                    case Operation.VratiMesta:
                        r.Odgovor = Controller.Instance.VratiMesta((Mesto)req.Argument);
                        break;
                    case Operation.KreirajMesto:
                        r.Odgovor = Controller.Instance.KreirajMesto((Mesto)req.Argument);
                        if (r.Odgovor == null)
                        {
                            throw new Exception();
                        }
                        break;
                    case Operation.VratiVodice:
                        r.Odgovor = Controller.Instance.VratiVodice((Vodic)req.Argument);
                        break;
                    case Operation.KreirajVodica:
                        r.Odgovor = Controller.Instance.KreirajVodica((Vodic)req.Argument);
                        if (r.Odgovor == null)
                        {
                            throw new Exception();
                        }
                        break;
                    case Operation.ObrisiVodica:
                        r.Odgovor = Controller.Instance.ObrisiVodica((Vodic)req.Argument);
                        if (r.Odgovor == null)
                        {
                            throw new Exception();
                        }
                        break;
                    case Operation.KreirajSadrzaj:
                        r.Odgovor = Controller.Instance.KreirajSadrzaj((Sadrzaj)req.Argument);
                        if (r.Odgovor == null)
                        {
                            throw new Exception();
                        }
                        break;
                    case Operation.KreirajAranzman:
                        r.Odgovor = Controller.Instance.KreirajAranzman((Aranzman)req.Argument);
                        if (r.Odgovor == null)
                        {
                            throw new Exception();
                        }
                        break;
                    case Operation.VratiAranzmane:
                        r.Odgovor = Controller.Instance.VratiAranzmane((Aranzman)req.Argument);
                        break;
                    case Operation.ObrisiAranzman:
                        r.Odgovor = Controller.Instance.ObrisiAranzman((Aranzman)req.Argument);
                        if (r.Odgovor == null)
                        {
                            throw new Exception();
                        }
                        break;
                    case Operation.IzmeniAranzman:
                        r.Odgovor = Controller.Instance.IzmeniAranzman((Aranzman)req.Argument);
                        if (r.Odgovor == null)
                        {
                            throw new Exception();
                        }
                        break;
                    case Operation.VratiTermine:
                        r.Odgovor = Controller.Instance.VratiTermine((Termin)req.Argument);
                        break;
                    case Operation.KreirajTermin:
                        r.Odgovor = Controller.Instance.KreirajTermin((Termin)req.Argument);
                        if (r.Odgovor == null)
                        {
                            throw new Exception();
                        }
                        break;
                    case Operation.ObrisiTermin:
                        r.Odgovor = Controller.Instance.ObrisiTermin((Termin)req.Argument);
                        if (r.Odgovor == null)
                        {
                            throw new Exception();
                        }
                        break;
                    case Operation.IzmeniTermin:
                        r.Odgovor = Controller.Instance.IzmeniTermin((Termin)req.Argument);
                        if (r.Odgovor == null)
                        {
                            throw new Exception();
                        }
                        break;
                    case Operation.Logout:
                        Server.klijenti.Remove(this);
                        Close();
                        Debug.WriteLine(">>>>>>>>>>>>>>>>Klijent ode");
                        break;
                    default:
                        break;
                } 
            }
            catch (NullReferenceException e)
            {
                r.Exception = e;
                Debug.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                r.Exception = e;
                Debug.WriteLine(e.Message);
            }
            return r;
        }
    }
}
