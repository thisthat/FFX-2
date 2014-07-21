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
       
        int offset_inventario = 31616;
        int offset_accessori = 32192;
        int offset_point_argento = 0xDE8; //Due Byte
        int offset_point_azzurro = 0xDE4; //Due Byte
        int offset_sposa = 0xDEC;
        int offset_init_looksfere = 0x784D;
        int offset_end_looksfere = 0x785C;
        int offset_looksfere_special = 0x785E;
        int offset_floralia = 0x7861;
        int offset_automastino = 0x7868;
        int offset_suprema = 0x7869;

        //All Item
        int offset_start_item = 0x7980;
        int offset_end_item = 0x7A07;


        byte[] file;
        string path;

        CRC checksum;

        public const int N_ITEMS = 0x44;

        public GeneralOffset(byte[] f,string p, CRC checksum)
        {
            this.file = f;
            this.path = p;
            this.checksum = checksum;
        }
        public int PointAzzurro
        {
            get
            {
                string _b2 = Utility.Byte2Hex(this.file[offset_point_azzurro + 0]);
                string _b1 = Utility.Byte2Hex(this.file[offset_point_azzurro + 1]);
                return Utility.Hex2Dec(_b1 + _b2);
            }
            set
            {
                string hex = Utility.Int2HexPad4(value);
                string _b2 = hex.Substring(0, 2);
                string _b1 = hex.Substring(2, 2);
                this.file[offset_point_azzurro + 0] = Utility.Hex2Byte(_b1);
                this.file[offset_point_azzurro + 1] = Utility.Hex2Byte(_b2);
                this.checksum.SetChecksum();
            }
        }
        public int PointArgento
        {
            get
            {
                string _b2 = Utility.Byte2Hex(this.file[offset_point_argento + 0]);
                string _b1 = Utility.Byte2Hex(this.file[offset_point_argento + 1]);
                return Utility.Hex2Dec(_b1 + _b2);
            }
            set
            {
                string hex = Utility.Int2HexPad4(value);
                string _b2 = hex.Substring(0, 2);
                string _b1 = hex.Substring(2, 2);
                this.file[offset_point_argento + 0] = Utility.Hex2Byte(_b1);
                this.file[offset_point_argento + 1] = Utility.Hex2Byte(_b2);
                this.checksum.SetChecksum();
            }
        }
        public byte PointSposa
        {
            get
            {
                return this.file[offset_sposa];
            }
            set
            {
                this.file[offset_sposa] = value;
                this.checksum.SetChecksum();
            }
        }
        public int Percentage
        {
            get
            {
                return this.file[offset_percentage];
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
                Console.WriteLine(_b1 + _b2 + _b3 + _b4);
                this.file[offset_time + 0] = Utility.Hex2Byte(_b1);
                this.file[offset_time + 1] = Utility.Hex2Byte(_b2);
                this.file[offset_time + 2] = Utility.Hex2Byte(_b3);
                this.file[offset_time + 3] = Utility.Hex2Byte(_b4);
                this.checksum.SetChecksum();
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
                this.checksum.SetChecksum();
            }
        }

        public void setAccessori()
        {
            //Modifichiamo gli accessori
            int start = offset_accessori;
            while (file[start] != 0)
            {
                //Console.WriteLine(file[start]);
                file[start] = 99;
                start++;
            }
            this.checksum.SetChecksum();
        }
        public void setInventario()
        {
            //Modifichiamo gli oggetti
            int start = offset_inventario;
            while (file[start] != 0)
            {
                //Console.WriteLine(file[start]);
                file[start] = 99;
                start++;
            }
            this.checksum.SetChecksum();
        }

        public void setInventario(int elm)
        {
            //Modifichiamo gli oggetti
            for (int i = offset_inventario; i < offset_inventario + elm; i++)
            {
                file[i] = 99;
            }
            this.checksum.SetChecksum();
        }

        public void setAllLooksfere()
        {
            for (int i = offset_init_looksfere; i < offset_end_looksfere; i++)
            {
                file[i] = 1;
            }
            file[offset_looksfere_special] = 1;
            file[offset_floralia] = 1;
            file[offset_automastino] = 1;
            file[offset_suprema] = 1;
            this.checksum.SetChecksum();
        }

        public void setAllItem(bool isSel99Item)
        {
            byte j = 0;
            for (int i = offset_start_item; i < offset_end_item; i += 2)
            {
                file[i] = j++;
                file[i + 1] = 0x20;
            }
            if (isSel99Item)
            {
                //68 elements
                setInventario(N_ITEMS);
            }
        }

    }
}
