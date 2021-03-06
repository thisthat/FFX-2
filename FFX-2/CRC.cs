﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FFX_2
{
    class CRC : INotifyPropertyChanged
    {
        //Binding with UI
        public event PropertyChangedEventHandler PropertyChanged;
        // Create the OnPropertyChanged method to raise the event 
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }


        const ushort poly = 0x1021;
        ushort[] table = new ushort[256];
        int start = 0x40;
        int end = 0x1626B;
        int offset_chk = 0x16268;
        byte[] file;
        string chksum = "";

        int offset_patch_first = 0x1A;
        int offset_patch_second = 0x16268;

        public string Checksum
        {
            get
            {
                return chksum;
            }
            set
            {
                chksum = value;
                OnPropertyChanged("Checksum");
            }
        }
        //Write Checksum to file
        public void SetChecksum()
        {
            ushort crc = ComputeChecksum();
            string hex = Utility.Byte2Hex(crc);
            string pad = "";
            while (hex.Length - 4 > 0)
            {
                pad += "0";
            }
            hex = pad + hex;
            string _b2 = hex.Substring(0, 2);
            string _b1 = hex.Substring(2, 2);
            this.Checksum = _b1 + _b2;
            byte b1 = Utility.Hex2Byte(_b1);
            byte b2 = Utility.Hex2Byte(_b2);
            file[offset_patch_first + 0] = b1;
            file[offset_patch_first + 1] = b2;
            file[offset_patch_second + 0] = b1;
            file[offset_patch_second + 1] = b2;
            //MessageBox.Show(hex);
        }
        public ushort ComputeChecksum()
        {
            //Set 0 to previus value of chksum
            file[offset_chk + 0] = 0;
            file[offset_chk + 1] = 0;
            file[offset_chk + 2] = 0;
            file[offset_chk + 3] = 0;
            //Execute checksum CRC16 ITU-T
            ushort crc = 0xFFFF;
            for (int i = this.start; i <= this.end; ++i)
            {
                crc = (ushort)((crc << 8) ^ table[((crc >> 8) ^ (0xFF & file[i]))]);
            }
            //http://srecord.sourceforge.net/crc16-ccitt.html
            return (ushort)(~crc);
        }

        public CRC(byte[] _file, int _start, int _end)
        {
            this.start = _start;
            this.end = _end;
            this.file = _file;
            init_table();
        }

        public CRC(byte[] _file)
        {
            this.file = _file;
            init_table();
        }

        public void init_table()
        {
            //Built table from polinomy
            ushort temp, a;
            for (int i = 0; i < table.Length; ++i)
            {
                temp = 0;
                a = (ushort)(i << 8);
                for (int j = 0; j < 8; ++j)
                {
                    if (((temp ^ a) & 0x8000) != 0)
                    {
                        temp = (ushort)((temp << 1) ^ poly);
                    }
                    else
                    {
                        temp <<= 1;
                    }
                    a <<= 1;
                }
                table[i] = temp;
            }
            //Special Entry
            table[0xFF] = 0;
        }
    }
}
