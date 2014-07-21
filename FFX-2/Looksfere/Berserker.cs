using FFX_2.looksfere;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFX_2.Looksfere
{
    class Berserker : Looksfera
    {
        private void InitYuna()
        {
            offset_yuna.Add(new Offset("8E82", "1E"));
            offset_yuna.Add(new Offset("8E86", "14"));
            offset_yuna.Add(new Offset("8E88", "1E"));
            offset_yuna.Add(new Offset("8E8A", "1E"));
            offset_yuna.Add(new Offset("8E8C", "28"));
            offset_yuna.Add(new Offset("8E8E", "28"));
            offset_yuna.Add(new Offset("8E90", "32"));
            offset_yuna.Add(new Offset("8E92", "1E"));
            offset_yuna.Add(new Offset("8E94", "3C"));
            offset_yuna.Add(new Offset("8E84", "50"));
            offset_yuna.Add(new Offset("92CA", "14"));
            offset_yuna.Add(new Offset("9214", "B4"));
            offset_yuna.Add(new Offset("9218", "012C"));
            offset_yuna.Add(new Offset("9216", "0190"));
            offset_yuna.Add(new Offset("92EC", "50"));
        }
        private void InitRikku()
        {
            offset_rikku.Add(new Offset("9522", "1E"));
            offset_rikku.Add(new Offset("9526", "14"));
            offset_rikku.Add(new Offset("9528", "1E"));
            offset_rikku.Add(new Offset("952A", "1E"));
            offset_rikku.Add(new Offset("952C", "28"));
            offset_rikku.Add(new Offset("952E", "28"));
            offset_rikku.Add(new Offset("9530", "32"));
            offset_rikku.Add(new Offset("9532", "1E"));
            offset_rikku.Add(new Offset("9534", "3C"));
            offset_rikku.Add(new Offset("9524", "50"));
            offset_rikku.Add(new Offset("996A", "14"));
            offset_rikku.Add(new Offset("98B4", "B4"));
            offset_rikku.Add(new Offset("98B8", "012C"));
            offset_rikku.Add(new Offset("98B6", "0190"));
            offset_rikku.Add(new Offset("998C", "50"));
        }
        private void InitPaine()
        {
            offset_paine.Add(new Offset("9BC2", "1E"));
            offset_paine.Add(new Offset("9BC6", "14"));
            offset_paine.Add(new Offset("9BC8", "1E"));
            offset_paine.Add(new Offset("9BCA", "1E"));
            offset_paine.Add(new Offset("9BCC", "28"));
            offset_paine.Add(new Offset("9BCE", "28"));
            offset_paine.Add(new Offset("9BD0", "32"));
            offset_paine.Add(new Offset("9BD2", "1E"));
            offset_paine.Add(new Offset("9BD4", "3C"));
            offset_paine.Add(new Offset("9BC4", "50"));
            offset_paine.Add(new Offset("A00A", "14"));
            offset_paine.Add(new Offset("9F54", "B4"));
            offset_paine.Add(new Offset("9F58", "012C"));
            offset_paine.Add(new Offset("9F56", "0190"));
            offset_paine.Add(new Offset("A02C", "50"));
        }


        public Berserker()
        {
            InitYuna();
            InitRikku();
            InitPaine();
        }
    }
}
