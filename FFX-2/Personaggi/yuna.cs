using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFX_2.Personaggi
{
    class Yuna
    {
        int offset_run_yuna = 33328;

        byte[] file;
        CRC checksum;

        public Yuna(byte[] f,CRC chksum)
        {
            this.file = f;
            checksum = chksum;
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
    }
}
