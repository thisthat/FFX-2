using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFX_2
{
    class Utility
    {
        public static int Hex2Dec(string hex)
        {
            return Convert.ToInt32(hex, 16);
        }
        public static byte Hex2Byte(string hex)
        {
            return Convert.ToByte(hex, 16);
        }
        public static string Byte2Hex(byte b)
        {
            return b.ToString("X2");
        }
        public static string Guil2Hex(int guil)
        {
            string hex = guil.ToString("X4");
            int distanza = 8 - hex.Length;
            for (int i = 0; i < distanza; i++)
            {
                hex += "0";
            }
            return hex;
        }

        internal static string Time2Hex(int p)
        {
            string hex = p.ToString("X4");
            int distanza = 8 - hex.Length;
            for (int i = 0; i < distanza; i++)
            {
                hex += "0";
            }
            return hex;
        }
    }
}
