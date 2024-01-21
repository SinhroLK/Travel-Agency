﻿using Common.Communication;
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

        internal object VratiMesta()
        {
            Request request = new Request
            {
                Operation = Operation.VratiGradove
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
    }
}
