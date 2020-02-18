﻿using UGPangya.API;
using UGPangya.API.Handles;
using UGPangya.Connector.Repository;
using UGPangya.LoginServer.Handles_Packet;

namespace UGPangya.LoginServer.Handles
{
    public class Handle_PLAYER_SELECT_CHARACTER : HandleBase<Packet_PLAYER_SELECT_CHARACTER>
    {
        public Handle_PLAYER_SELECT_CHARACTER(Player player) : base(player)
        {
            var CODE = new ProcedureRepository().USP_FIRST_CREATION(Player.Member.UID, PacketResult.CHAR_TYPEID,
                PacketResult.HAIR_COLOR, Player.Member.Nickname);

            //Success
            if (CODE == 1)
            {
                Player.Response.Write(new byte[] {0x11, 0x00, 0x00});
                Player.SendResponse();
                new Handle_Shared().SendPlayerLoggedOnData(Player);
            }
            //Error
            else
            {
                Player.Disconnect();
            }
        }
    }
}