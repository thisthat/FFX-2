using FFX_2.looksfere;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFX_2.Looksfere
{
    class Alchimista : Looksfera
    {
        private void InitYuna()
        {
            offset_yuna.Add(new Offset("8E20", "28"));
            offset_yuna.Add(new Offset("8E22", "0A"));
            offset_yuna.Add(new Offset("8E24", "28"));
            offset_yuna.Add(new Offset("8E26", "78"));
            offset_yuna.Add(new Offset("8E28", "A0"));
            offset_yuna.Add(new Offset("8E2A", "14"));
            offset_yuna.Add(new Offset("8E2C", "14"));
            offset_yuna.Add(new Offset("8E2E", "1E"));
            offset_yuna.Add(new Offset("8E30", "C8"));
            offset_yuna.Add(new Offset("8E32", "0190"));
            offset_yuna.Add(new Offset("8E34", "03E7"));
            offset_yuna.Add(new Offset("924E", "1E"));
            offset_yuna.Add(new Offset("921C", "28"));
            offset_yuna.Add(new Offset("921E", "50"));
            offset_yuna.Add(new Offset("9220", "64"));
        }
        private void InitRikku()
        {
            offset_rikku.Add(new Offset("94C0", "28"));
            offset_rikku.Add(new Offset("94C2", "0A"));
            offset_rikku.Add(new Offset("94C4", "28"));
            offset_rikku.Add(new Offset("94C6", "78"));
            offset_rikku.Add(new Offset("94C8", "A0"));
            offset_rikku.Add(new Offset("94CA", "14"));
            offset_rikku.Add(new Offset("94CC", "14"));
            offset_rikku.Add(new Offset("94CE", "1E"));
            offset_rikku.Add(new Offset("94D0", "C8"));
            offset_rikku.Add(new Offset("94D2", "0190"));
            offset_rikku.Add(new Offset("94D4", "03E7"));
            offset_rikku.Add(new Offset("98EE", "1E"));
            offset_rikku.Add(new Offset("98BC", "28"));
            offset_rikku.Add(new Offset("98BE", "50"));
            offset_rikku.Add(new Offset("98C0", "64"));
        }
        private void InitPaine()
        {
            offset_paine.Add(new Offset("9B60", "28"));
            offset_paine.Add(new Offset("9B62", "0A"));
            offset_paine.Add(new Offset("9B64", "28"));
            offset_paine.Add(new Offset("9B66", "78"));
            offset_paine.Add(new Offset("9B68", "A0"));
            offset_paine.Add(new Offset("9B6A", "14"));
            offset_paine.Add(new Offset("9B6C", "14"));
            offset_paine.Add(new Offset("9B6E", "1E"));
            offset_paine.Add(new Offset("9B70", "C8"));
            offset_paine.Add(new Offset("9B72", "0190"));
            offset_paine.Add(new Offset("9B74", "03E7"));
            offset_paine.Add(new Offset("9F8E", "1E"));
            offset_paine.Add(new Offset("9F5C", "28"));
            offset_paine.Add(new Offset("9F5E", "50"));
            offset_paine.Add(new Offset("9F60", "64"));
        }


        public Alchimista()
        {
            InitYuna();
            InitRikku();
            InitPaine();
        }
    }
}
