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

        public ClientHandler(Socket socket)
        {
            this.socket = socket;
            sender = new Sender(socket);
            receiver = new Receiver(socket);
        }

        internal void HandleRequest()
        {
            while (true)
            {
                Request req = (Request)receiver.Receive();
                Response r = ProcessRequest(req);
                sender.Send(r);
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
                        break;
                    case Operation.VratiGradove:
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
                    default:
                        break;
                }
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
