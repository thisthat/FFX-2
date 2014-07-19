using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFX_2.looksfere
{
    class Nerarcano : Looksfera
    {
        private void InitYuna()
        {
            offset_yuna.Add(new Offset("8EBA", "14"));
            offset_yuna.Add(new Offset("8EBC", "14"));
            offset_yuna.Add(new Offset("8EBE", "14"));
            offset_yuna.Add(new Offset("8EC0", "14"));
            offset_yuna.Add(new Offset("8EC2", "28"));
            offset_yuna.Add(new Offset("8EC4", "28"));
            offset_yuna.Add(new Offset("8EC6", "28"));
            offset_yuna.Add(new Offset("8EC8", "28"));
            offset_yuna.Add(new Offset("8ECA", "64"));
            offset_yuna.Add(new Offset("8ECC", "64"));
            offset_yuna.Add(new Offset("8ECE", "64"));
            offset_yuna.Add(new Offset("8ED0", "64"));
            offset_yuna.Add(new Offset("8EB6", "0A"));
            offset_yuna.Add(new Offset("8EB8", "0A"));
            offset_yuna.Add(new Offset("9250", "28"));
            offset_yuna.Add(new Offset("9252", "3C"));
        }
        private void InitRikku()
        {
            offset_rikku.Add(new Offset("955A", "14"));
            offset_rikku.Add(new Offset("955C", "14"));
            offset_rikku.Add(new Offset("955E", "14"));
            offset_rikku.Add(new Offset("9560", "14"));
            offset_rikku.Add(new Offset("9562", "28"));
            offset_rikku.Add(new Offset("9564", "28"));
            offset_rikku.Add(new Offset("9566", "28"));
            offset_rikku.Add(new Offset("9568", "28"));
            offset_rikku.Add(new Offset("956A", "64"));
            offset_rikku.Add(new Offset("956C", "64"));
            offset_rikku.Add(new Offset("956E", "64"));
            offset_rikku.Add(new Offset("9570", "64"));
            offset_rikku.Add(new Offset("9556", "0A"));
            offset_rikku.Add(new Offset("9558", "0A"));
            offset_rikku.Add(new Offset("98F0", "28"));
            offset_rikku.Add(new Offset("98F2", "3C"));
        }
        private void InitPaine()
        {
            offset_paine.Add(new Offset("9BFA", "14"));
            offset_paine.Add(new Offset("9BFC", "14"));
            offset_paine.Add(new Offset("9BFE", "14"));
            offset_paine.Add(new Offset("9C00", "14"));
            offset_paine.Add(new Offset("9C02", "28"));
            offset_paine.Add(new Offset("9C04", "28"));
            offset_paine.Add(new Offset("9C06", "28"));
            offset_paine.Add(new Offset("9C08", "28"));
            offset_paine.Add(new Offset("9C0A", "64"));
            offset_paine.Add(new Offset("9C0C", "64"));
            offset_paine.Add(new Offset("9C0E", "64"));
            offset_paine.Add(new Offset("9C10", "64"));
            offset_paine.Add(new Offset("9BF6", "0A"));
            offset_paine.Add(new Offset("9BF8", "0A"));
            offset_paine.Add(new Offset("9F90", "28"));
            offset_paine.Add(new Offset("9F92", "3C"));
        }


        public Nerarcano()
        {
            InitYuna();
            InitRikku();
            InitPaine();
        }
    }
}
