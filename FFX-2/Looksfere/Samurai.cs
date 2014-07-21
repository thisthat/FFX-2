using FFX_2.looksfere;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFX_2.Looksfere
{
    class Samurai : Looksfera
    {
        private void InitYuna()
        {
            offset_yuna.Add(new Offset("8E6A", "14"));
            offset_yuna.Add(new Offset("8E52", "1E"));
            offset_yuna.Add(new Offset("8E54", "1E"));
            offset_yuna.Add(new Offset("8E56", "1E"));
            offset_yuna.Add(new Offset("8E58", "28"));
            offset_yuna.Add(new Offset("8E5A", "28"));
            offset_yuna.Add(new Offset("8E5C", "3C"));
            offset_yuna.Add(new Offset("8E5E", "3C"));
            offset_yuna.Add(new Offset("8E60", "64"));
            offset_yuna.Add(new Offset("8E62", "14"));
            offset_yuna.Add(new Offset("8E64", "1E"));
            offset_yuna.Add(new Offset("8E66", "28"));
            offset_yuna.Add(new Offset("8E68", "3C"));
            offset_yuna.Add(new Offset("8E6C", "8C"));
            offset_yuna.Add(new Offset("9306", "50"));
        }
        private void InitRikku()
        {
            offset_rikku.Add(new Offset("950A", "14"));
            offset_rikku.Add(new Offset("94F2", "1E"));
            offset_rikku.Add(new Offset("94F4", "1E"));
            offset_rikku.Add(new Offset("94F6", "1E"));
            offset_rikku.Add(new Offset("94F8", "28"));
            offset_rikku.Add(new Offset("94FA", "28"));
            offset_rikku.Add(new Offset("94FC", "3C"));
            offset_rikku.Add(new Offset("94FE", "3C"));
            offset_rikku.Add(new Offset("9500", "64"));
            offset_rikku.Add(new Offset("9502", "14"));
            offset_rikku.Add(new Offset("9504", "1E"));
            offset_rikku.Add(new Offset("9506", "28"));
            offset_rikku.Add(new Offset("9508", "3C"));
            offset_rikku.Add(new Offset("950C", "8C"));
            offset_rikku.Add(new Offset("99A6", "50"));
        }
        private void InitPaine()
        {
            offset_paine.Add(new Offset("9BAA", "14"));
            offset_paine.Add(new Offset("9B92", "1E"));
            offset_paine.Add(new Offset("9B94", "1E"));
            offset_paine.Add(new Offset("9B96", "1E"));
            offset_paine.Add(new Offset("9B98", "28"));
            offset_paine.Add(new Offset("9B9A", "28"));
            offset_paine.Add(new Offset("9B9C", "3C"));
            offset_paine.Add(new Offset("9B9E", "3C"));
            offset_paine.Add(new Offset("9BA0", "64"));
            offset_paine.Add(new Offset("9BA2", "14"));
            offset_paine.Add(new Offset("9BA4", "1E"));
            offset_paine.Add(new Offset("9BA6", "28"));
            offset_paine.Add(new Offset("9BA8", "3C"));
            offset_paine.Add(new Offset("9BAC", "8C"));
            offset_paine.Add(new Offset("A046", "50"));
        }


        public Samurai()
        {
            InitYuna();
            InitRikku();
            InitPaine();
        }
    }
}
