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
        public bool LastPoint = true;


        internal List<Offset> offset_yuna;
        internal List<Offset> offset_rikku;
        internal List<Offset> offset_paine;
        internal YRP pg;
        internal int Hex2Dec(string hex)
        {
            return Convert.ToInt32(hex, 16);
        }
        internal byte Hex2Byte(string hex)
        {
            return Convert.ToByte(hex, 16);
        }


        public void write(byte[] file)
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
                int search = Hex2Dec(off.Search);
                byte value = Hex2Byte(off.Value);
                if (LastPoint) { value--; }
                file[search] = value;
            }
        }
    }
}
