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


        internal List<Offset> offset_yuna = new List<Offset>();
        internal List<Offset> offset_rikku = new List<Offset>();
        internal List<Offset> offset_paine = new List<Offset>();
        internal YRP pg;
        


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
                int search = FFX_2.Utility.Hex2Dec(off.Search);
                byte value = FFX_2.Utility.Hex2Byte(off.Value);
                if (LastPoint) { value--; }
                file[search] = value;
            }
        }
    }
}
