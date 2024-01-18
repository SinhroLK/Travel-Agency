﻿using Common.Communication;
using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }
    }
}