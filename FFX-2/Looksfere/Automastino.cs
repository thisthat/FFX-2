using FFX_2.looksfere;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFX_2.Looksfere
{
    class Automastino : Looksfera
    {
        private void InitAutomastino()
        {
            offset_rikku.Add(new Offset("9680", "0A"));
            offset_rikku.Add(new Offset("9670", "0A"));
            offset_rikku.Add(new Offset("9672", "0A"));
            offset_rikku.Add(new Offset("9674", "0A"));
            offset_rikku.Add(new Offset("9676", "0A"));
            offset_rikku.Add(new Offset("9678", "0A"));
            offset_rikku.Add(new Offset("967A", "0A"));
            offset_rikku.Add(new Offset("967C", "14"));
            offset_rikku.Add(new Offset("967E", "14"));
            offset_rikku.Add(new Offset("9682", "1E"));
            offset_rikku.Add(new Offset("9980", "1E"));
            offset_rikku.Add(new Offset("9994", "14"));
            offset_rikku.Add(new Offset("9996", "1E"));
            offset_rikku.Add(new Offset("98C6", "14"));
            offset_rikku.Add(new Offset("98CA", "14"));
        }

        private void Crusher()
        {
            offset_rikku.Add(new Offset("B7C0", "0A"));
            offset_rikku.Add(new Offset("B7C2", "0A"));
            offset_rikku.Add(new Offset("B7C4", "0A"));
            offset_rikku.Add(new Offset("B7C6", "0A"));
            offset_rikku.Add(new Offset("B7C8", "0A"));
            offset_rikku.Add(new Offset("B7CA", "14"));
            offset_rikku.Add(new Offset("B7CC", "14"));
            offset_rikku.Add(new Offset("B7CE", "14"));
            offset_rikku.Add(new Offset("B7BA", "0A"));
            offset_rikku.Add(new Offset("B7BC", "0A"));
            offset_rikku.Add(new Offset("B7BE", "0A"));
            offset_rikku.Add(new Offset("BAA0", "1E"));
            offset_rikku.Add(new Offset("BAB4", "14"));
            offset_rikku.Add(new Offset("BAB6", "1E"));
            offset_rikku.Add(new Offset("B9E6", "14"));
            offset_rikku.Add(new Offset("B9EA", "14"));
        }

        private void Smasher()
        {
            offset_rikku.Add(new Offset("B10A", "0A"));
            offset_rikku.Add(new Offset("B10C", "0A"));
            offset_rikku.Add(new Offset("B10E", "0A"));
            offset_rikku.Add(new Offset("B110", "0A"));
            offset_rikku.Add(new Offset("B112", "0A"));
            offset_rikku.Add(new Offset("B114", "0A"));
            offset_rikku.Add(new Offset("B116", "14"));
            offset_rikku.Add(new Offset("B118", "14"));
            offset_rikku.Add(new Offset("B104", "0A"));
            offset_rikku.Add(new Offset("B106", "0A"));
            offset_rikku.Add(new Offset("B108", "0A"));
            offset_rikku.Add(new Offset("B400", "1E"));
            offset_rikku.Add(new Offset("B414", "14"));
            offset_rikku.Add(new Offset("B416", "1E"));
            offset_rikku.Add(new Offset("B346", "14"));
            offset_rikku.Add(new Offset("B34A", "14"));
        }

        public Automastino()
        {
            InitAutomastino();
            Smasher();
            Crusher();
        }
        public byte[] write(byte[] file)
        {
            foreach (Offset off in offset_rikku)
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
