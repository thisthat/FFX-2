using FFX_2.looksfere;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFX_2.Looksfere
{
    class CavaliereNero : Looksfera
    {
        private void InitYuna()
        {
            offset_yuna.Add(new Offset("8E6E", "1E"));
            offset_yuna.Add(new Offset("8E72", "14"));
            offset_yuna.Add(new Offset("8E74", "14"));
            offset_yuna.Add(new Offset("8E76", "1E"));
            offset_yuna.Add(new Offset("8E78", "28"));
            offset_yuna.Add(new Offset("8E7A", "1E"));
            offset_yuna.Add(new Offset("8E7C", "14"));
            offset_yuna.Add(new Offset("8E7E", "32"));
            offset_yuna.Add(new Offset("8E80", "64"));
            offset_yuna.Add(new Offset("8E70", "14"));
            offset_yuna.Add(new Offset("92B8", "1E"));
            offset_yuna.Add(new Offset("92A8", "1E"));
            offset_yuna.Add(new Offset("92BC", "1E"));
            offset_yuna.Add(new Offset("92C6", "1E"));
            offset_yuna.Add(new Offset("92A4", "28"));
        }
        private void InitRikku()
        {
            offset_rikku.Add(new Offset("950E", "1E"));
            offset_rikku.Add(new Offset("9512", "14"));
            offset_rikku.Add(new Offset("9514", "14"));
            offset_rikku.Add(new Offset("9516", "1E"));
            offset_rikku.Add(new Offset("9518", "28"));
            offset_rikku.Add(new Offset("951A", "1E"));
            offset_rikku.Add(new Offset("951C", "14"));
            offset_rikku.Add(new Offset("951E", "32"));
            offset_rikku.Add(new Offset("9520", "64"));
            offset_rikku.Add(new Offset("9510", "14"));
            offset_rikku.Add(new Offset("9958", "1E"));
            offset_rikku.Add(new Offset("9948", "1E"));
            offset_rikku.Add(new Offset("995C", "1E"));
            offset_rikku.Add(new Offset("9966", "1E"));
            offset_rikku.Add(new Offset("9944", "28"));
        }
        private void InitPaine()
        {
            offset_paine.Add(new Offset("9BAE", "1E"));
            offset_paine.Add(new Offset("9BB2", "14"));
            offset_paine.Add(new Offset("9BB4", "14"));
            offset_paine.Add(new Offset("9BB6", "1E"));
            offset_paine.Add(new Offset("9BB8", "28"));
            offset_paine.Add(new Offset("9BBA", "1E"));
            offset_paine.Add(new Offset("9BBC", "14"));
            offset_paine.Add(new Offset("9BBE", "32"));
            offset_paine.Add(new Offset("9BC0", "64"));
            offset_paine.Add(new Offset("9BB0", "14"));
            offset_paine.Add(new Offset("9FF8", "1E"));
            offset_paine.Add(new Offset("9FE8", "1E"));
            offset_paine.Add(new Offset("9FFC", "1E"));
            offset_paine.Add(new Offset("A006", "1E"));
            offset_paine.Add(new Offset("9FE4", "28"));
        }


        public CavaliereNero()
        {
            InitYuna();
            InitRikku();
            InitPaine();
        }

    }
}
