﻿using UGPangya.API;
using UGPangya.API.BinaryModels;
using UGPangya.GameServer.Handles_Packet;

namespace UGPangya.GameServer.Handles
{
    public class Handle_PLAYER_ACTION_SHOT : HandleBase<Packet_PLAYER_ACTION_SHOT>
    {
        public Handle_PLAYER_ACTION_SHOT(Player player) : base(player)
        {
            Handle();
        }

        private void Handle()
        {
            var result = new PangyaBinaryWriter();

            result.Write(new byte[] {0x55, 0x00});
            result.Write(Player.ConnectionId);
            result.Write(PacketResult.Un);

            Player.Game.SendToAll(result);
        }
    }
}