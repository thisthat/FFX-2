using FFX_2.looksfere;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFX_2.Looksfere
{
    class Suprema : Looksfera
    {
        private void InitSuprema()
        {
            offset_paine.Add(new Offset("9D60", "14"));
            offset_paine.Add(new Offset("9D50", "0A"));
            offset_paine.Add(new Offset("9D52", "0A"));
            offset_paine.Add(new Offset("9D54", "0A"));
            offset_paine.Add(new Offset("9D56", "0A"));
            offset_paine.Add(new Offset("9D58", "0A"));
            offset_paine.Add(new Offset("9D5A", "14"));
            offset_paine.Add(new Offset("9D5C", "14"));
            offset_paine.Add(new Offset("9D5E", "14"));
            offset_paine.Add(new Offset("9D62", "1E"));
            offset_paine.Add(new Offset("A020", "1E"));
            offset_paine.Add(new Offset("A034", "14"));
            offset_paine.Add(new Offset("A036", "1E"));
            offset_paine.Add(new Offset("9F66", "14"));
            offset_paine.Add(new Offset("9F6A", "14"));
        }
        private void PTERONS()
        {
            offset_paine.Add(new Offset("C542", "0A"));
            offset_paine.Add(new Offset("C544", "0A"));
            offset_paine.Add(new Offset("C546", "0A"));
            offset_paine.Add(new Offset("C548", "0A"));
            offset_paine.Add(new Offset("C53E", "0A"));
            offset_paine.Add(new Offset("C540", "0A"));
            offset_paine.Add(new Offset("C54A", "0A"));
            offset_paine.Add(new Offset("C54C", "0A"));
            offset_paine.Add(new Offset("C54E", "0A"));
            offset_paine.Add(new Offset("C7E0", "1E"));
            offset_paine.Add(new Offset("C7F4", "14"));
            offset_paine.Add(new Offset("C7F6", "1E"));
            offset_paine.Add(new Offset("C726", "14"));
            offset_paine.Add(new Offset("C72A", "14"));
        }

        private void PTEROND()
        {
            offset_paine.Add(new Offset("BE84", "0A"));
            offset_paine.Add(new Offset("BE86", "0A"));
            offset_paine.Add(new Offset("BE88", "0A"));
            offset_paine.Add(new Offset("BE8A", "0A"));
            offset_paine.Add(new Offset("BE8C", "0A"));
            offset_paine.Add(new Offset("BE8E", "0A"));
            offset_paine.Add(new Offset("BE90", "0A"));
            offset_paine.Add(new Offset("BE92", "0A"));
            offset_paine.Add(new Offset("BE94", "0A"));
            offset_paine.Add(new Offset("BE96", "0A"));
            offset_paine.Add(new Offset("BE98", "0A"));
            offset_paine.Add(new Offset("C140", "1E"));
            offset_paine.Add(new Offset("C154", "14"));
            offset_paine.Add(new Offset("C156", "1E"));
            offset_paine.Add(new Offset("C086", "14"));
            offset_paine.Add(new Offset("C08A", "14"));
        }

        public Suprema()
        {
            InitSuprema();
            PTEROND();
            PTERONS();
        }

        public byte[] write(byte[] file)
        {
            foreach (Offset off in offset_paine)
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
