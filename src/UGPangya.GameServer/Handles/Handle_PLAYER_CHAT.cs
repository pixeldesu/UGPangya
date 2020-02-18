﻿using System;
using UGPangya.API;
using UGPangya.API.BinaryModels;
using UGPangya.GameServer.Handles_Packet;

namespace UGPangya.GameServer.Handles
{
    public class Handle_PLAYER_CHAT : HandleBase<Packet_PLAYER_CHAT>
    {
        public Handle_PLAYER_CHAT(Player player) : base(player)
        {
            Handle();
            HandleChatCommands();
        }

        private void Handle()
        {
            var response = new PangyaBinaryWriter();

            response.Write(new byte[] {0x40, 0x00});
            response.Write((byte) (Player.Member_Old.Capabilities == 4 || Player.Member_Old.Capabilities == 15
                ? 0x80
                : 0)); //Tipo de chat           
            response.WritePStr(PacketResult.Nickname);
            response.WritePStr(PacketResult.Message);

            Player.Channel.Lobby.SendToAll(response.GetBytes());
        }

        private void HandleChatCommands()
        {
            var comando = PacketResult.Message.Split(' ');

            if (comando[0].ToUpper() == "HANDLE")
                switch (comando[1].ToUpper())
                {
                    case "PLAYER_START_GAME":
                    {
                        Console.WriteLine("Chat Command: " + comando[1]);
                        new Handle_PLAYER_START_GAME(Player);
                    }
                        break;

                    case "GAMES_LIST":
                    {
                        Player.Channel.Lobby.GameManager.List(Player);
                    }
                        break;
                }
        }
    }
}