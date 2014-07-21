using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFX_2.Personaggi
{
    class Paine
    {
        byte[] file;
        CRC checksum;
        int offset_run_paine = 33584;
        int offset_st_hp = 0x82F4;
        int offset_nd_hp = 0x830C;
        int offset_rd_hp = 0x8314;
        int offset_st_mp = 0x82F8;
        int offset_nd_mp = 0x8310;
        int offset_rd_mp = 0x8318;

        public Paine(byte[] f, CRC chksum)
        {
            this.file = f;
            checksum = chksum;
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
                this.checksum.SetChecksum();
            }
        }
        public int HPPaine
        {
            get
            {
                string _b4 = Utility.Byte2Hex(this.file[offset_nd_hp + 0]);
                string _b3 = Utility.Byte2Hex(this.file[offset_nd_hp + 1]);
                string _b2 = Utility.Byte2Hex(this.file[offset_nd_hp + 2]);
                string _b1 = Utility.Byte2Hex(this.file[offset_nd_hp + 3]);
                return Utility.Hex2Dec(_b1 + _b2 + _b3 + _b4);
            }
            set
            {
                string hex = Utility.Int2HexPad8(value);
                string _b4 = hex.Substring(0, 2);
                string _b3 = hex.Substring(2, 2);
                string _b2 = hex.Substring(4, 2);
                string _b1 = hex.Substring(6, 2);
                this.file[offset_st_hp + 0] = Utility.Hex2Byte(_b1);
                this.file[offset_st_hp + 1] = Utility.Hex2Byte(_b2);
                this.file[offset_st_hp + 2] = Utility.Hex2Byte(_b3);
                this.file[offset_st_hp + 3] = Utility.Hex2Byte(_b4);
                this.file[offset_nd_hp + 0] = Utility.Hex2Byte(_b1);
                this.file[offset_nd_hp + 1] = Utility.Hex2Byte(_b2);
                this.file[offset_nd_hp + 2] = Utility.Hex2Byte(_b3);
                this.file[offset_nd_hp + 3] = Utility.Hex2Byte(_b4);
                this.file[offset_rd_hp + 0] = Utility.Hex2Byte(_b1);
                this.file[offset_rd_hp + 1] = Utility.Hex2Byte(_b2);
                this.file[offset_rd_hp + 2] = Utility.Hex2Byte(_b3);
                this.file[offset_rd_hp + 3] = Utility.Hex2Byte(_b4);
                this.checksum.SetChecksum();
            }
        }

        public int MPPaine
        {
            get
            {
                string _b2 = Utility.Byte2Hex(this.file[offset_nd_mp + 0]);
                string _b1 = Utility.Byte2Hex(this.file[offset_nd_mp + 1]);
                return Utility.Hex2Dec(_b1 + _b2);
            }
            set
            {
                string hex = Utility.Int2HexPad4(value);
                string _b2 = hex.Substring(0, 2);
                string _b1 = hex.Substring(2, 2);
                this.file[offset_st_mp + 0] = Utility.Hex2Byte(_b1);
                this.file[offset_st_mp + 1] = Utility.Hex2Byte(_b2);
                this.file[offset_nd_mp + 0] = Utility.Hex2Byte(_b1);
                this.file[offset_nd_mp + 1] = Utility.Hex2Byte(_b2);
                this.file[offset_rd_mp + 0] = Utility.Hex2Byte(_b1);
                this.file[offset_rd_mp + 1] = Utility.Hex2Byte(_b2);
                this.checksum.SetChecksum();
            }
        }
    }
}
