using FFX_2.looksfere;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFX_2.Looksfere
{
    class Psichica : Looksfera
    {
        private void InitYuna()
        {
            offset_yuna.Add(new Offset("913C", "14"));
            offset_yuna.Add(new Offset("9140", "1E"));
            offset_yuna.Add(new Offset("913E", "1E"));
            offset_yuna.Add(new Offset("9142", "1E"));
            offset_yuna.Add(new Offset("9146", "28"));
            offset_yuna.Add(new Offset("914C", "1E"));
            offset_yuna.Add(new Offset("9144", "64"));
            offset_yuna.Add(new Offset("9148", "50"));
            offset_yuna.Add(new Offset("914A", "50"));
            offset_yuna.Add(new Offset("914E", "78"));
            offset_yuna.Add(new Offset("926A", "28"));
            offset_yuna.Add(new Offset("9272", "28"));
            offset_yuna.Add(new Offset("927A", "28"));
            offset_yuna.Add(new Offset("9282", "28"));
            offset_yuna.Add(new Offset("928A", "3C"));
        }
        private void InitRikku()
        {
            offset_rikku.Add(new Offset("97DC", "14"));
            offset_rikku.Add(new Offset("97E0", "1E"));
            offset_rikku.Add(new Offset("97DE", "1E"));
            offset_rikku.Add(new Offset("97E2", "1E"));
            offset_rikku.Add(new Offset("97E6", "28"));
            offset_rikku.Add(new Offset("97EC", "1E"));
            offset_rikku.Add(new Offset("97E4", "64"));
            offset_rikku.Add(new Offset("97E8", "50"));
            offset_rikku.Add(new Offset("97EA", "50"));
            offset_rikku.Add(new Offset("97EE", "78"));
            offset_rikku.Add(new Offset("990A", "28"));
            offset_rikku.Add(new Offset("9912", "28"));
            offset_rikku.Add(new Offset("991A", "28"));
            offset_rikku.Add(new Offset("9922", "28"));
            offset_rikku.Add(new Offset("992A", "3C"));
        }
        private void InitPaine()
        {
            offset_paine.Add(new Offset("9E7C", "14"));
            offset_paine.Add(new Offset("9E80", "1E"));
            offset_paine.Add(new Offset("9E7E", "1E"));
            offset_paine.Add(new Offset("9E82", "1E"));
            offset_paine.Add(new Offset("9E86", "28"));
            offset_paine.Add(new Offset("9E8C", "1E"));
            offset_paine.Add(new Offset("9E84", "64"));
            offset_paine.Add(new Offset("9E88", "50"));
            offset_paine.Add(new Offset("9E8A", "50"));
            offset_paine.Add(new Offset("9E8E", "78"));
            offset_paine.Add(new Offset("9FAA", "28"));
            offset_paine.Add(new Offset("9FB2", "28"));
            offset_paine.Add(new Offset("9FBA", "28"));
            offset_paine.Add(new Offset("9FC2", "28"));
            offset_paine.Add(new Offset("9FCA", "3C"));
        }

        public Psichica()
        {
            InitYuna();
            InitRikku();
            InitPaine();
        }
    }
}
