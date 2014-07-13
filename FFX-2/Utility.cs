using System;
using System.Collections.Generic;
using System.IO;
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
            string pad = "";
            for (int i = 0; i < distanza; i++)
            {
                pad += "0";
            }
            return pad + hex;
        }

        public static string Time2Hex(int p)
        {
            string hex = p.ToString("X4");
            int distanza = 8 - hex.Length;
            string pad = "";
            for (int i = 0; i < distanza; i++)
            {
                pad += "0";
            }
            return pad + hex;
        }
        public static void writeFile(byte[] file,string path){
            File.WriteAllBytes(path + "/SAVES", file);
        }
    }
}
