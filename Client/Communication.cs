using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

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

        public void Connect()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("127.0.0.1", 9999);
            sender = new Sender(socket);
            receiver = new Receiver(socket);
        }

        internal Response Login(Admin user)
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

        internal object VratiMesta(Mesto mesto)
        {
            Request request = new Request
            {
                Argument = mesto,
                Operation = Operation.VratiMesta
            };
            sender.Send(request);
            Response response = (Response)receiver.Receive();
            Console.WriteLine(response.Odgovor);
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
            Console.WriteLine(response.Odgovor);
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
    }
}
