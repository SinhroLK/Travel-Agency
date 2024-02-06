using Client.UserControls;
using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public class Communication
    {
        private static Communication _instance;
        public static Communication Instance
        {
            get
            {
                if (_instance == null) _instance = new Communication();
                return _instance;
            }
        }
        private Communication()
        {
        }

        Socket socket;
        Sender sender;
        Receiver receiver;

        public bool Connect()
        {
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect("127.0.0.1", 9999);
                sender = new Sender(socket);
                receiver = new Receiver(socket);
                return true;
            }
            catch (SocketException se)
            {
                Debug.WriteLine(">>>nije upaljen server>>>" + se.ToString());
                return false;
            }
        }

        internal Response Login(Admin user)
        {
            try
            {
                Request req = new Request
                {
                    Argument = user,
                    Operation = Operation.Login
                };
                sender.Send(req);
                Response response = (Response)receiver.Receive();
                return response;
            }
            catch (Exception)
            {
                return null;
            }
        }

        internal object VratiMesta(Mesto mesto)
        {

            Request request = new Request
            {
                Argument = mesto,
                Operation = Operation.VratiMesta
            };
            sender.Send(request);
            Response response = (Response)receiver.Receive();
            if(response == null)
            {
                return response;
            }
            //Console.WriteLine(response.Odgovor);
            return response.Odgovor;
        }

        internal Response KreirajMesto(Mesto mesto)
        {
            Request request = new Request
            {
                Argument = mesto,
                Operation = Operation.KreirajMesto
            };
            sender.Send(request);
            Response response = (Response)receiver.Receive();
            //if (response == null)
            //{
            //    return response;
            //}
            return response;
        }

        internal object VratiVodice(Vodic vodic)
        {
            Request request = new Request
            {
                Argument = vodic,
                Operation = Operation.VratiVodice
            };
            sender.Send(request);
            Response response = (Response)receiver.Receive();
            if (response == null)
            {
                return response;
            }
            // Console.WriteLine(response.Odgovor);
            return response.Odgovor;
        }
        internal Response KreirajVodica(Vodic vodic)
        {
            Request request = new Request
            {
                Argument = vodic,
                Operation = Operation.KreirajVodica
            };
            sender.Send(request);
            Response response = (Response)receiver.Receive();
            return response;
        }

        internal Response ObrisiVodica(Vodic vodic)
        {
            Request request = new Request 
            { 
                Argument = vodic, 
                Operation = Operation.ObrisiVodica 
            };
            sender.Send(request);
            Response response = (Response)receiver.Receive();
            return response;
        }

        internal Response KreirajSadrzaj(Sadrzaj sadrzaj)
        {
            Request request = new Request
            {
                Argument = sadrzaj,
                Operation = Operation.KreirajSadrzaj
            };
            sender.Send(request);
            Response response = (Response)receiver.Receive();
            return response;
        }

        internal object VratiAranzmane(Aranzman aranzman)
        {
            Request request = new Request
            {
                Argument = aranzman,
                Operation = Operation.VratiAranzmane
            };
            sender.Send(request);
            Response response = (Response)receiver.Receive();
            if (response == null)
            {
                return response;
            }
            // Console.WriteLine(response.Odgovor);
            return response.Odgovor;
        }

        internal Response KreirajAranzman(Aranzman aranzman)
        {
            Request request = new Request
            {
                Argument = aranzman,
                Operation = Operation.KreirajAranzman
            };
            sender.Send(request);
            Response response = (Response)receiver.Receive();
            return response;
        }

        internal Response ObrisiAranzman(Aranzman aranzman)
        {
            Request request = new Request
            {
                Argument = aranzman,
                Operation = Operation.ObrisiAranzman
            };
            sender.Send(request);
            Response response = (Response)receiver.Receive();
            return response;
        }

        internal Response IzmeniAranzman(Aranzman aranzman)
        {
            Request request = new Request
            {
                Argument = aranzman,
                Operation = Operation.IzmeniAranzman
            };
            sender.Send(request);
            Response response = (Response)receiver.Receive();
            return response;
        }

        internal object VratiTermine(Termin termin)
        {
            Request request = new Request
            {
                Argument = termin,
                Operation = Operation.VratiTermine
            };
            sender.Send(request);
            Response response = (Response)receiver.Receive();
            if (response == null)
            {
                return response;
            }
            // Console.WriteLine(response.Odgovor);
            return response.Odgovor;
        }

        internal Response KreirajTermin(Termin termin)
        {
            Request request = new Request
            {
                Argument = termin,
                Operation = Operation.KreirajTermin
            };
            sender.Send(request);
            Response response = (Response)receiver.Receive();
            return response;
        }

        internal Response ObrisiTermin(Termin termin)
        {
            Request request = new Request
            {
                Argument = termin,
                Operation = Operation.ObrisiTermin
            };
            sender.Send(request);
            Response response = (Response)receiver.Receive();
            return response;
        }

        internal Response IzmeniTermin(Termin termin)
        {
            Request request = new Request
            {
                Argument = termin,
                Operation = Operation.IzmeniTermin
            };
            sender.Send(request);
            Response response = (Response)receiver.Receive();
            return response;
        }
        internal void Logout()
        {
            Request request = new Request
            {
                Argument = null,
                Operation = Operation.Logout
            };
            sender.Send(request);
            Close();
        }

        internal void Close()
        {
            socket?.Shutdown(SocketShutdown.Both);
            socket?.Close();
            socket = null;
        }

    }
}
