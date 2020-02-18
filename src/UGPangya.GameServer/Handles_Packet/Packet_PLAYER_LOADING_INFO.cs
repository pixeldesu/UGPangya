﻿using UGPangya.API.BinaryModels;

namespace UGPangya.GameServer.Handles_Packet
{
    public class Packet_PLAYER_LOADING_INFO : PacketResult
    {
        public byte Progress { get; set; }

        public override void Load(PangyaBinaryReader reader)
        {
            Progress = reader.ReadByte();
        }
    }
}