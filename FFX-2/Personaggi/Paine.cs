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
    }
}
