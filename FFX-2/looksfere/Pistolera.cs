using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFX_2.looksfere
{
    class Pistolera : Looksfera
    {
        

        private void InitYuna()
        {
            offset_yuna.Add(new Offset("8DD4", "1E"));
            offset_yuna.Add(new Offset("8DD6", "14"));
            offset_yuna.Add(new Offset("8DD8", "1E"));
            offset_yuna.Add(new Offset("8DDA", "1E"));
            offset_yuna.Add(new Offset("8DDC", "1E"));
            offset_yuna.Add(new Offset("8DDE", "28"));
            offset_yuna.Add(new Offset("8DE0", "28"));
            offset_yuna.Add(new Offset("8DE2", "3C"));
            offset_yuna.Add(new Offset("8DE4", "3C"));
            offset_yuna.Add(new Offset("8DE6", "50"));
            offset_yuna.Add(new Offset("8DE8", "78"));
            offset_yuna.Add(new Offset("92B4", "1E"));
            offset_yuna.Add(new Offset("92AC", "1E"));
            offset_yuna.Add(new Offset("9240", "50"));
            offset_yuna.Add(new Offset("9242", "96"));
        }
        private void InitRikku()
        {
            offset_rikku.Add(new Offset("9474", "1E"));
            offset_rikku.Add(new Offset("9476", "14"));
            offset_rikku.Add(new Offset("9478", "1E"));
            offset_rikku.Add(new Offset("947A", "1E"));
            offset_rikku.Add(new Offset("947C", "1E"));
            offset_rikku.Add(new Offset("947E", "28"));
            offset_rikku.Add(new Offset("9480", "28"));
            offset_rikku.Add(new Offset("9482", "3C"));
            offset_rikku.Add(new Offset("9484", "3C"));
            offset_rikku.Add(new Offset("9486", "50"));
            offset_rikku.Add(new Offset("9488", "78"));
            offset_rikku.Add(new Offset("9954", "1E"));
            offset_rikku.Add(new Offset("994C", "1E"));
            offset_rikku.Add(new Offset("98E0", "50"));
            offset_rikku.Add(new Offset("98E2", "96"));
        }

        private void InitPaine()
        {
            offset_paine.Add(new Offset("9B14", "1E"));
            offset_paine.Add(new Offset("9B16", "14"));
            offset_paine.Add(new Offset("9B18", "1E"));
            offset_paine.Add(new Offset("9B1A", "1E"));
            offset_paine.Add(new Offset("9B1C", "1E"));
            offset_paine.Add(new Offset("9B1E", "28"));
            offset_paine.Add(new Offset("9B20", "28"));
            offset_paine.Add(new Offset("9B22", "3C"));
            offset_paine.Add(new Offset("9B24", "3C"));
            offset_paine.Add(new Offset("9B26", "50"));
            offset_paine.Add(new Offset("9B28", "78"));
            offset_paine.Add(new Offset("9FF4", "1E"));
            offset_paine.Add(new Offset("9FEC", "1E"));
            offset_paine.Add(new Offset("9F80", "50"));
            offset_paine.Add(new Offset("9F82", "96"));
        }

        public Pistolera()
        {
            InitYuna();
            InitRikku();
            InitPaine();
        }

        
    }
}
