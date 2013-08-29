﻿using Communication.Logic;
using Network.Server;
using Tera.Services;
using Utils;

namespace Network.Client
{
    public class CpCheckNameForUse : ARecvPacket
    {
        protected short Type;
        protected string Name;

        public override void Read()
        {
            Type = (short) ReadH();
            Name = ReadS();
        }

        public override void Process()
        {
            PlayerLogic.CheckNameForUse(Connection, Name, Type);
        }
    }
}