using FFX_2.looksfere;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFX_2.Looksfere
{
    class Floralia : Looksfera
    {
        private void InitFloralia()
        {
            offset_yuna.Add(new Offset("8F9A", "04"));
            offset_yuna.Add(new Offset("8F8E", "0A"));
            offset_yuna.Add(new Offset("8F90", "0A"));
            offset_yuna.Add(new Offset("8F92", "0A"));
            offset_yuna.Add(new Offset("8F94", "0A"));
            offset_yuna.Add(new Offset("8F98", "14"));
            offset_yuna.Add(new Offset("8F96", "14"));
            offset_yuna.Add(new Offset("8F9C", "18"));
            offset_yuna.Add(new Offset("8FA0", "1E"));
            offset_yuna.Add(new Offset("8F9E", "14"));
            offset_yuna.Add(new Offset("92E0", "1E"));
            offset_yuna.Add(new Offset("92F4", "14"));
            offset_yuna.Add(new Offset("92F6", "1E"));
            offset_yuna.Add(new Offset("9226", "14"));
            offset_yuna.Add(new Offset("922A", "14"));
        }

        private void GeaD()
        {
            offset_yuna.Add(new Offset("A382", "0A"));
            offset_yuna.Add(new Offset("A384", "0A"));
            offset_yuna.Add(new Offset("A386", "0A"));
            offset_yuna.Add(new Offset("A388", "0A"));
            offset_yuna.Add(new Offset("A38A", "0A"));
            offset_yuna.Add(new Offset("A38C", "14"));
            offset_yuna.Add(new Offset("A38E", "0A"));
            offset_yuna.Add(new Offset("A390", "0A"));
            offset_yuna.Add(new Offset("A392", "0A"));
            offset_yuna.Add(new Offset("A394", "0A"));
            offset_yuna.Add(new Offset("A396", "14"));
            offset_yuna.Add(new Offset("A6C0", "1E"));
            offset_yuna.Add(new Offset("A6D4", "14"));
            offset_yuna.Add(new Offset("A6D6", "1E"));
            offset_yuna.Add(new Offset("A606", "14"));
            offset_yuna.Add(new Offset("A60A", "14"));
        }

        private void GeaS()
        {
            offset_yuna.Add(new Offset("AA38", "0A"));
            offset_yuna.Add(new Offset("AA3A", "0A"));
            offset_yuna.Add(new Offset("AA3C", "0A"));
            offset_yuna.Add(new Offset("AA3E", "0A"));
            offset_yuna.Add(new Offset("AA40", "0A"));
            offset_yuna.Add(new Offset("AA42", "0A"));
            offset_yuna.Add(new Offset("AA4A", "14"));
            offset_yuna.Add(new Offset("AA48", "14"));
            offset_yuna.Add(new Offset("AA46", "0A"));
            offset_yuna.Add(new Offset("AA44", "0A"));
            offset_yuna.Add(new Offset("AA4C", "14"));
            offset_yuna.Add(new Offset("AD60", "1E"));
            offset_yuna.Add(new Offset("AD74", "14"));
            offset_yuna.Add(new Offset("AD76", "1E"));
            offset_yuna.Add(new Offset("ACA6", "14"));
            offset_yuna.Add(new Offset("ACAA", "14"));
        }


        public Floralia()
        {
            InitFloralia();
            GeaD();
            GeaS();
        }

        public byte[] write(byte[] file)
        {
            foreach (Offset off in offset_yuna)
            {
                int search = FFX_2.Utility.Hex2Dec(off.Search);
                byte value = FFX_2.Utility.Hex2Byte(off.Value);
                //if (LastPoint) { value--; }
                file[search] = value;
            }
            return file;
        }


    }
}
