using FFX_2.looksfere;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFX_2.Looksfere
{
    class Domatrice : Looksfera
    {
        private void InitYuna()
        {
            offset_yuna.Add(new Offset("8F12", "1E"));
            offset_yuna.Add(new Offset("8F02", "28"));
            offset_yuna.Add(new Offset("8F04", "28"));
            offset_yuna.Add(new Offset("8F06", "28"));
            offset_yuna.Add(new Offset("8F08", "28"));
            offset_yuna.Add(new Offset("8F0A", "50"));
            offset_yuna.Add(new Offset("8F0C", "50"));
            offset_yuna.Add(new Offset("8F0E", "1E"));
            offset_yuna.Add(new Offset("8F10", "28"));
            offset_yuna.Add(new Offset("8F14", "64"));
            offset_yuna.Add(new Offset("9248", "C8"));
            offset_yuna.Add(new Offset("9238", "14"));
            offset_yuna.Add(new Offset("923A", "14"));
            offset_yuna.Add(new Offset("9258", "50"));
            offset_yuna.Add(new Offset("925A", "64"));
        }
        private void InitRikku()
        {
            offset_rikku.Add(new Offset("95C6", "1E"));
            offset_rikku.Add(new Offset("95B6", "28"));
            offset_rikku.Add(new Offset("95B8", "50"));
            offset_rikku.Add(new Offset("95BA", "28"));
            offset_rikku.Add(new Offset("95BC", "64"));
            offset_rikku.Add(new Offset("95BE", "64"));
            offset_rikku.Add(new Offset("95C2", "28"));
            offset_rikku.Add(new Offset("95C0", "1E"));
            offset_rikku.Add(new Offset("95C4", "50"));
            offset_rikku.Add(new Offset("95C8", "64"));
            offset_rikku.Add(new Offset("98E8", "C8"));
            offset_rikku.Add(new Offset("98D8", "14"));
            offset_rikku.Add(new Offset("98DA", "14"));
            offset_rikku.Add(new Offset("98FC", "50"));
            offset_rikku.Add(new Offset("98FE", "64"));
        }
        private void InitPaine()
        {
            offset_paine.Add(new Offset("9C76", "1E"));
            offset_paine.Add(new Offset("9C6A", "28"));
            offset_paine.Add(new Offset("9C6C", "3C"));
            offset_paine.Add(new Offset("9C6E", "3C"));
            offset_paine.Add(new Offset("9C70", "3C"));
            offset_paine.Add(new Offset("9C72", "3C"));
            offset_paine.Add(new Offset("9C74", "3C"));
            offset_paine.Add(new Offset("9C7A", "28"));
            offset_paine.Add(new Offset("9C78", "28"));
            offset_paine.Add(new Offset("9C7C", "64"));
            offset_paine.Add(new Offset("9F88", "C8"));
            offset_paine.Add(new Offset("9F78", "14"));
            offset_paine.Add(new Offset("9F7A", "14"));
            offset_paine.Add(new Offset("9FA0", "50"));
            offset_paine.Add(new Offset("9FA2", "64"));
        }


        public Domatrice()
        {
            InitYuna();
            InitRikku();
            InitPaine();
        }
    }
}
