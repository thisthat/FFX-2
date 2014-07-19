using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFX_2.looksfere
{
    class Festaiola : Looksfera
    {
        private void InitYuna()
        {
            offset_yuna.Add(new Offset("9164", "1E"));
            offset_yuna.Add(new Offset("9158", "1E"));
            offset_yuna.Add(new Offset("915E", "1E"));
            offset_yuna.Add(new Offset("916A", "28"));
            offset_yuna.Add(new Offset("9170", "1E"));
            offset_yuna.Add(new Offset("9172", "1E"));
            offset_yuna.Add(new Offset("9174", "1E"));
            offset_yuna.Add(new Offset("9176", "1E"));
            offset_yuna.Add(new Offset("9178", "3C"));
            offset_yuna.Add(new Offset("917A", "64"));
            offset_yuna.Add(new Offset("9236", "1E"));
            offset_yuna.Add(new Offset("92B0", "1E"));
            offset_yuna.Add(new Offset("92C8", "14"));
            offset_yuna.Add(new Offset("92FE", "1E"));
            offset_yuna.Add(new Offset("9346", "64"));
        }
        private void InitRikku()
        {
            offset_rikku.Add(new Offset("9806", "1E"));
            offset_rikku.Add(new Offset("97FA", "1E"));
            offset_rikku.Add(new Offset("9800", "1E"));
            offset_rikku.Add(new Offset("980C", "28"));
            offset_rikku.Add(new Offset("981C", "1E"));
            offset_rikku.Add(new Offset("981E", "1E"));
            offset_rikku.Add(new Offset("9820", "1E"));
            offset_rikku.Add(new Offset("9822", "1E"));
            offset_rikku.Add(new Offset("9824", "3C"));
            offset_rikku.Add(new Offset("9826", "64"));
            offset_rikku.Add(new Offset("996E", "14"));
            offset_rikku.Add(new Offset("9972", "28"));
            offset_rikku.Add(new Offset("9968", "14"));
            offset_rikku.Add(new Offset("999E", "1E"));
            offset_rikku.Add(new Offset("99E6", "64"));
        }
        private void InitPaine()
        {
            offset_paine.Add(new Offset("9EA8", "1E"));
            offset_paine.Add(new Offset("9E9C", "1E"));
            offset_paine.Add(new Offset("9EAE", "1E"));
            offset_paine.Add(new Offset("980C", "28"));
            offset_paine.Add(new Offset("9ECA", "1E"));
            offset_paine.Add(new Offset("9EC8", "1E"));
            offset_paine.Add(new Offset("9ECE", "1E"));
            offset_paine.Add(new Offset("9ECC", "1E"));
            offset_paine.Add(new Offset("9ED0", "3C"));
            offset_paine.Add(new Offset("9ED2", "64"));
            offset_paine.Add(new Offset("A00E", "14"));
            offset_paine.Add(new Offset("A012", "28"));
            offset_paine.Add(new Offset("A040", "32"));
            offset_paine.Add(new Offset("A03E", "1E"));
            offset_paine.Add(new Offset("A086", "64"));
        }


        public Festaiola()
        {
            InitYuna();
            InitRikku();
            InitPaine();
        }
    }
}
