using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Wpf.Toolkit;

namespace FFX_2
{
    class GeneralOffset
    {
        int offset_percentage = 12;
        int offset_time = 16;
        int offset_guil = 30744;
        int offset_run_yuna = 33328;
        int offset_run_rikku = 33456;
        int offset_run_paine = 33584;
        int offset_inventario = 31616;
        int offset_accessori = 32192;
        int offset_patch_first = 0x1A;
        int offset_patch_second = 0x16268;

        byte[] file;
        string path;

        CRC checksum;

        public GeneralOffset(byte[] f,string p, CRC checksum)
        {
            this.file = f;
            this.path = p;
            this.checksum = checksum;
        }

        public int Percentage
        {
            get
            {
                return this.file[offset_percentage];
            }
        }
        public byte RunYuna
        {
            get
            {
                return this.file[offset_run_yuna];
            }
            set
            {
                this.file[offset_run_yuna] = value;
                this.checksum.SetChecksum();
            }
        }
        public byte RunRikku
        {
            get
            {
                return this.file[offset_run_rikku];
            }
            set
            {
                this.file[offset_run_rikku] = value;
                Utility.writeFile(this.file, path);
            }
        }
        public byte RunPaine
        {
            get
            {
                return this.file[offset_run_paine];
            }
            set
            {
                this.file[offset_run_paine] = value;
                Utility.writeFile(this.file, path);
            }
        }
        public int Time
        {
            get
            {
                string _b4 = Utility.Byte2Hex(this.file[offset_time]);
                string _b3 = Utility.Byte2Hex(this.file[offset_time + 1]);
                string _b2 = Utility.Byte2Hex(this.file[offset_time + 2]);
                string _b1 = Utility.Byte2Hex(this.file[offset_time + 3]);
                return Utility.Hex2Dec(_b1 + _b2 + _b3 + _b4);

            }
            set
            {
                string hex = Utility.Time2Hex(value);
                string _b4 = hex.Substring(0, 2);
                string _b3 = hex.Substring(2, 2);
                string _b2 = hex.Substring(4, 2);
                string _b1 = hex.Substring(6, 2);
                this.file[offset_time + 0] = Utility.Hex2Byte(_b1);
                this.file[offset_time + 1] = Utility.Hex2Byte(_b2);
                this.file[offset_time + 2] = Utility.Hex2Byte(_b3);
                this.file[offset_time + 3] = Utility.Hex2Byte(_b4);
                Utility.writeFile(this.file, path);
            }
        }
        public int Guil
        {
            get
            {
                string _b4 = Utility.Byte2Hex(this.file[offset_guil + 0]);
                string _b3 = Utility.Byte2Hex(this.file[offset_guil + 1]);
                string _b2 = Utility.Byte2Hex(this.file[offset_guil + 2]);
                string _b1 = Utility.Byte2Hex(this.file[offset_guil + 3]);
                return Utility.Hex2Dec(_b1 + _b2 + _b3 + _b4);

            }
            set
            {
                string hex = Utility.Guil2Hex(value);
                string _b4 = hex.Substring(0, 2);
                string _b3 = hex.Substring(2, 2);
                string _b2 = hex.Substring(4, 2);
                string _b1 = hex.Substring(6, 2);
                this.file[offset_guil + 0] = Utility.Hex2Byte(_b1);
                this.file[offset_guil + 1] = Utility.Hex2Byte(_b2);
                this.file[offset_guil + 2] = Utility.Hex2Byte(_b3);
                this.file[offset_guil + 3] = Utility.Hex2Byte(_b4);
                Utility.writeFile(this.file, path);
            }
        }

        public void setAccessori()
        {
            //Modifichiamo gli accessori
            int start = offset_accessori;
            while (file[start] != 0)
            {
                Console.WriteLine(file[start]);
                file[start] = 99;
                start++;
            }
            Utility.writeFile(this.file, path);
        }
        public void setInventario()
        {
            //Modifichiamo gli oggetti
            int start = offset_inventario;
            while (file[start] != 0)
            {
                Console.WriteLine(file[start]);
                file[start] = 99;
                start++;
            }
            Utility.writeFile(this.file, path);
        }

        public void Patch(string bytePatch)
        {
            byte _b1 = Utility.Hex2Byte(bytePatch.Substring(0, 2));
            byte _b2 = Utility.Hex2Byte(bytePatch.Substring(2));
            file[offset_patch_first + 0] = _b1;
            file[offset_patch_first + 1] = _b2;
            file[offset_patch_second + 0] = _b1;
            file[offset_patch_second + 1] = _b2;
            Utility.writeFile(this.file, path);
        }

    }
}
