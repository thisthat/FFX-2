using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFX_2.looksfere
{
    class Guerriera : Looksfera
    {
        private void InitYuna()
        {
            offset_yuna.Add(new Offset("8E38", "14"));
            offset_yuna.Add(new Offset("8E42", "14"));
            offset_yuna.Add(new Offset("8E44", "14"));
            offset_yuna.Add(new Offset("8E46", "14"));
            offset_yuna.Add(new Offset("8E48", "14"));
            offset_yuna.Add(new Offset("8E4A", "3C"));
            offset_yuna.Add(new Offset("8E4C", "78"));
            offset_yuna.Add(new Offset("8E3A", "1E"));
            offset_yuna.Add(new Offset("8E3C", "1E"));
            offset_yuna.Add(new Offset("8E3E", "1E"));
            offset_yuna.Add(new Offset("8E40", "1E"));
            offset_yuna.Add(new Offset("8E4E", "64"));
            offset_yuna.Add(new Offset("8E50", "78"));
            offset_yuna.Add(new Offset("8E36", "64"));
            offset_yuna.Add(new Offset("92FA", "14"));
        }
        private void InitRikku()
        {
            offset_rikku.Add(new Offset("94D8", "14"));
            offset_rikku.Add(new Offset("94E2", "14"));
            offset_rikku.Add(new Offset("94E4", "14"));
            offset_rikku.Add(new Offset("94E6", "14"));
            offset_rikku.Add(new Offset("94E8", "14"));
            offset_rikku.Add(new Offset("94EA", "3C"));
            offset_rikku.Add(new Offset("94EC", "78"));
            offset_rikku.Add(new Offset("94DA", "1E"));
            offset_rikku.Add(new Offset("94DC", "1E"));
            offset_rikku.Add(new Offset("94DE", "1E"));
            offset_rikku.Add(new Offset("94E0", "1E"));
            offset_rikku.Add(new Offset("94EE", "64"));
            offset_rikku.Add(new Offset("94F0", "78"));
            offset_rikku.Add(new Offset("94D6", "64"));
            offset_rikku.Add(new Offset("999A", "14"));
        }
        private void InitPaine()
        {
            offset_paine.Add(new Offset("9B78", "14"));
            offset_paine.Add(new Offset("9B82", "14"));
            offset_paine.Add(new Offset("9B84", "14"));
            offset_paine.Add(new Offset("9B86", "14"));
            offset_paine.Add(new Offset("9B88", "14"));
            offset_paine.Add(new Offset("9B8A", "3C"));
            offset_paine.Add(new Offset("9B8C", "78"));
            offset_paine.Add(new Offset("9B7A", "1E"));
            offset_paine.Add(new Offset("9B7C", "1E"));
            offset_paine.Add(new Offset("9B7E", "1E"));
            offset_paine.Add(new Offset("9B80", "1E"));
            offset_paine.Add(new Offset("9B8E", "64"));
            offset_paine.Add(new Offset("9B90", "78"));
            offset_paine.Add(new Offset("9B76", "64"));
            offset_paine.Add(new Offset("A03A", "14"));
        }


        public Guerriera()
        {
            InitYuna();
            InitRikku();
            InitPaine();
        }
    }
}
