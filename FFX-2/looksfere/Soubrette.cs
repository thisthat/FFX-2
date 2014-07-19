using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFX_2.looksfere
{
    class Soubrette : Looksfera
    {
        private void InitYuna()
        {
            offset_yuna.Add(new Offset("8E96", "14"));
            offset_yuna.Add(new Offset("8E98", "14"));
            offset_yuna.Add(new Offset("8E9A", "14"));
            offset_yuna.Add(new Offset("8E9C", "14"));
            offset_yuna.Add(new Offset("8E9E", "50"));
            offset_yuna.Add(new Offset("8EA0", "50"));
            offset_yuna.Add(new Offset("8EA2", "3C"));
            offset_yuna.Add(new Offset("8EA4", "78"));
            offset_yuna.Add(new Offset("8EA6", "78"));
            offset_yuna.Add(new Offset("8EA8", "A0"));
            offset_yuna.Add(new Offset("8EAA", "0A"));
            offset_yuna.Add(new Offset("8EAC", "0A"));
            offset_yuna.Add(new Offset("8EAE", "0A"));
            offset_yuna.Add(new Offset("8EB0", "0A"));
            offset_yuna.Add(new Offset("8EB2", "0A"));
            offset_yuna.Add(new Offset("8EB4", "0A"));
        }
        private void InitRikku()
        {
            offset_rikku.Add(new Offset("9536", "14"));
            offset_rikku.Add(new Offset("9538", "14"));
            offset_rikku.Add(new Offset("953A", "14"));
            offset_rikku.Add(new Offset("953C", "14"));
            offset_rikku.Add(new Offset("953E", "50"));
            offset_rikku.Add(new Offset("9540", "50"));
            offset_rikku.Add(new Offset("9542", "3C"));
            offset_rikku.Add(new Offset("9544", "78"));
            offset_rikku.Add(new Offset("9546", "78"));
            offset_rikku.Add(new Offset("9548", "A0"));
            offset_rikku.Add(new Offset("954A", "0A"));
            offset_rikku.Add(new Offset("954C", "0A"));
            offset_rikku.Add(new Offset("954E", "0A"));
            offset_rikku.Add(new Offset("9550", "0A"));
            offset_rikku.Add(new Offset("9552", "0A"));
            offset_rikku.Add(new Offset("9554", "0A"));
        }
        private void InitPaine()
        {
            offset_paine.Add(new Offset("9BD6", "14"));
            offset_paine.Add(new Offset("9BD8", "14"));
            offset_paine.Add(new Offset("9BDA", "14"));
            offset_paine.Add(new Offset("9BDC", "14"));
            offset_paine.Add(new Offset("9BDE", "50"));
            offset_paine.Add(new Offset("9BE0", "50"));
            offset_paine.Add(new Offset("9BE2", "3C"));
            offset_paine.Add(new Offset("9BE4", "78"));
            offset_paine.Add(new Offset("9BE6", "78"));
            offset_paine.Add(new Offset("9BE8", "A0"));
            offset_paine.Add(new Offset("9BEA", "0A"));
            offset_paine.Add(new Offset("9BEC", "0A"));
            offset_paine.Add(new Offset("9BEE", "0A"));
            offset_paine.Add(new Offset("9BF0", "0A"));
            offset_paine.Add(new Offset("9BF2", "0A"));
            offset_paine.Add(new Offset("9BF4", "0A"));
        }


        public Soubrette()
        {
            InitYuna();
            InitRikku();
            InitPaine();
        }
    }
}
