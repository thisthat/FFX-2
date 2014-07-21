using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFX_2.Personaggi
{
    class Rikku
    {
        byte[] file;
        CRC checksum;
        int offset_run_rikku = 33456;
        
        public Rikku(byte[] f, CRC chksum)
        {
            this.file = f;
            checksum = chksum;
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
                this.checksum.SetChecksum();
            }
        }
    }
}
