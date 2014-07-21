using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFX_2.looksfere
{
    class Looksfera
    {
        public enum YRP
        {
            YUNA = 0,
            RIKKU,
            PAINE
        }

        public const string PISTOLERA = "pistolera";
        public const string BANDITA = "bandita";
        public const string GUERRIERA = "guerriera";
        public const string SOUBRETTE = "soubrette";
        public const string FESTAIOLA = "festaiola";
        public const string PSICHICA = "psichica";
        public const string NERARCANO = "nerarcano";
        public const string BIANCARCANO = "biancarcano";
        public const string MAGIPISTOLERA = "magipistolera";
        public const string CAVALIERE_NERO = "cavalierenero";
        public const string BERSERKER = "berserker";
        public const string ALCHIMISTA = "alchimista";
        public const string DEA_FORTUNATA = "deafortunata";
        public const string DOMATRICE = "domatrice";
        public const string SAMURAI = "samurai";
        public const string MASCOTTE = "mascotte";
        //Special Look
        public const string FLORALIA = "floralia";
        public const string AUTOMASTINO = "automastino";
        public const string SUPREMA = "suprema";

        public bool LastPoint = true;


        internal List<Offset> offset_yuna = new List<Offset>();
        internal List<Offset> offset_rikku = new List<Offset>();
        internal List<Offset> offset_paine = new List<Offset>();



        public byte[] write(byte[] file, YRP pg)
        {
            List<Offset> offset;
            switch (pg)
            {
                case YRP.YUNA: offset = offset_yuna; break;
                case YRP.RIKKU: offset = offset_rikku; break;
                case YRP.PAINE: offset = offset_paine; break;
                default: offset = offset_yuna; break;
            }
            foreach (Offset off in offset)
            {
                int search = FFX_2.Utility.Hex2Dec(off.Search);
                if (off.Value.Length > 2)
                {
                    byte _b1 = FFX_2.Utility.Hex2Byte(off.Value.Substring(0, 2));
                    byte _b2 = FFX_2.Utility.Hex2Byte(off.Value.Substring(2, 2));
                    file[search + 0] = _b1;
                    file[search + 1] = _b2;
                }
                else
                {
                    byte value = FFX_2.Utility.Hex2Byte(off.Value);
                    //if (LastPoint) { value--; }
                    file[search] = value;
                }
            }
            return file;
        }
    }
}
