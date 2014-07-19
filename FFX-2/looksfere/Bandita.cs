using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFX_2.looksfere
{
    class Bandita : Looksfera
    {
        private void InitYuna()
        {
            offset_yuna.Add(new Offset("8EEE", "14"));
            offset_yuna.Add(new Offset("8EF0", "1E"));
            offset_yuna.Add(new Offset("8EF2", "64"));
            offset_yuna.Add(new Offset("8EF4", "3C"));
            offset_yuna.Add(new Offset("8EF6", "3C"));
            offset_yuna.Add(new Offset("8EF8", "78"));
            offset_yuna.Add(new Offset("8EFA", "8C"));
            offset_yuna.Add(new Offset("8EFC", "A0"));
            offset_yuna.Add(new Offset("8EFE", "A0"));
            offset_yuna.Add(new Offset("8F00", "0A"));
            offset_yuna.Add(new Offset("9234", "3C"));
            offset_yuna.Add(new Offset("9210", "28"));
            offset_yuna.Add(new Offset("9212", "3C"));
            offset_yuna.Add(new Offset("92CE", "14"));
            offset_yuna.Add(new Offset("92D2", "28"));
        }
        private void InitRikku()
        {
            offset_rikku.Add(new Offset("958E", "14"));
            offset_rikku.Add(new Offset("9590", "1E"));
            offset_rikku.Add(new Offset("9592", "64"));
            offset_rikku.Add(new Offset("9594", "3C"));
            offset_rikku.Add(new Offset("9596", "3C"));
            offset_rikku.Add(new Offset("9598", "78"));
            offset_rikku.Add(new Offset("959A", "8C"));
            offset_rikku.Add(new Offset("959C", "A0"));
            offset_rikku.Add(new Offset("959E", "A0"));
            offset_rikku.Add(new Offset("95A0", "0A"));
            offset_rikku.Add(new Offset("98D4", "3C"));
            offset_rikku.Add(new Offset("98B0", "28"));
            offset_rikku.Add(new Offset("98B2", "3C"));
            offset_rikku.Add(new Offset("996E", "14"));
            offset_rikku.Add(new Offset("9972", "28"));
        }
        private void InitPaine()
        {
            offset_paine.Add(new Offset("9C2E", "14"));
            offset_paine.Add(new Offset("9C30", "1E"));
            offset_paine.Add(new Offset("9C32", "64"));
            offset_paine.Add(new Offset("9C34", "3C"));
            offset_paine.Add(new Offset("9C36", "3C"));
            offset_paine.Add(new Offset("9C38", "78"));
            offset_paine.Add(new Offset("9C3A", "8C"));
            offset_paine.Add(new Offset("9C3C", "A0"));
            offset_paine.Add(new Offset("9C3E", "A0"));
            offset_paine.Add(new Offset("9C40", "0A"));
            offset_paine.Add(new Offset("9F74", "3C"));
            offset_paine.Add(new Offset("9F50", "28"));
            offset_paine.Add(new Offset("9F52", "3C"));
            offset_paine.Add(new Offset("A00E", "14"));
            offset_paine.Add(new Offset("A012", "28"));
        }


        public Bandita()
        {
            InitYuna();
            InitRikku();
            InitPaine();
        }
    }
}
