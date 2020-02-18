﻿using System.Collections.Generic;
using System.Linq;
using UGPangya.API.BinaryModels;
using UGPangya.API.Repository;
using UGPangya.API.Repository.Models;

namespace UGPangya.API.Collections
{
    public class CaddieCollection : List<Caddie>
    {
        public CaddieCollection(Player player)
        {
            _player = player;
            _caddieRepository = new CaddieRepository();
            AddRange(_caddieRepository.GetByUID(player.Member_Old.UID));
        }

        private Player _player { get; }
        private CaddieRepository _caddieRepository { get; }


        public byte[] GetCaddieData()
        {
            var result = new PangyaBinaryWriter();

            result.Write(new byte[] {0x71, 0x00});
            result.Write((ushort) Count); //Total Caddie
            result.Write((ushort) Count); //Total Caddie

            foreach (var caddie in this)
            {
                result.Write(caddie.CID);
                result.Write(caddie.TYPEID);
                result.Write(caddie.SKIN_TYPEID.Value);
                result.Write(caddie.cLevel);
                result.Write(caddie.EXP);
                result.Write(caddie.RentFlag.Value);
                result.Write((ushort) caddie.DAY_LEFT);
                result.Write((ushort) caddie.SKIN_HOUR_LEFT);
                result.Write((byte) 0x00);
                result.Write((ushort) caddie.TriggerPay);
            }

            return result.GetBytes();
        }


        public byte[] ExpirationNotice()
        {
            var result = new PangyaBinaryWriter();
            var data = this.Where(c => c.RentFlag.Value == 2 && c.DAY_LEFT == 65530).FirstOrDefault();

            if (data != null)
            {
                result.Write(new byte[] {0xD4, 0x00});
                result.Write(1); //Total Caddie
                result.Write(data.CID);
                result.Write(data.TYPEID);
                result.Write(data.SKIN_TYPEID.Value);
                result.Write(data.cLevel);
                result.Write(data.EXP);
                result.Write(data.RentFlag.Value);
                result.Write(data.DAY_LEFT);
                result.Write((ushort) data.SKIN_HOUR_LEFT);
                result.Write((byte) 0x00);
                result.Write((ushort) data.TriggerPay);
                return result.GetBytes();
            }

            return null;
        }
    }
}