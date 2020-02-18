﻿using UGPangya.API;
using UGPangya.GameServer.Handles_Packet;

namespace UGPangya.GameServer.Handles
{
    public class Handle_PLAYER_1ST_SHOT_READY : HandleBase<Packet_PLAYER_1ST_SHOT_READY>
    {
        public Handle_PLAYER_1ST_SHOT_READY(Player player) : base(player)
        {
            Handle();
        }

        private void Handle()
        {
            Player.SendResponse(new byte[] {0x90, 0x00});
        }
    }
}