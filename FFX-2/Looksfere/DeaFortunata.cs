using FFX_2.looksfere;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFX_2.Looksfere
{
    class DeaFortunata : Looksfera
    {
        private void InitYuna()
        {
            offset_yuna.Add(new Offset("8F50", "28"));
            offset_yuna.Add(new Offset("8F46", "14"));
            offset_yuna.Add(new Offset("8F48", "64"));
            offset_yuna.Add(new Offset("8F3E", "3C"));
            offset_yuna.Add(new Offset("8F40", "46"));
            offset_yuna.Add(new Offset("8F42", "50"));
            offset_yuna.Add(new Offset("8F44", "78"));
            offset_yuna.Add(new Offset("8F4A", "1E"));
            offset_yuna.Add(new Offset("8F4C", "28"));
            offset_yuna.Add(new Offset("8F4E", "3C"));
            offset_yuna.Add(new Offset("92F0", "A0"));
            offset_yuna.Add(new Offset("9232", "50"));
            offset_yuna.Add(new Offset("9302", "1E"));
            offset_yuna.Add(new Offset("922E", "64"));
            offset_yuna.Add(new Offset("9230", "64"));
        }
        private void InitRikku()
        {
            offset_rikku.Add(new Offset("95F0", "28"));
            offset_rikku.Add(new Offset("95E6", "14"));
            offset_rikku.Add(new Offset("95E8", "64"));
            offset_rikku.Add(new Offset("95DE", "3C"));
            offset_rikku.Add(new Offset("95E0", "46"));
            offset_rikku.Add(new Offset("95E2", "50"));
            offset_rikku.Add(new Offset("95E4", "78"));
            offset_rikku.Add(new Offset("95EA", "1E"));
            offset_rikku.Add(new Offset("95EC", "28"));
            offset_rikku.Add(new Offset("95EE", "3C"));
            offset_rikku.Add(new Offset("9990", "A0"));
            offset_rikku.Add(new Offset("98D2", "50"));
            offset_rikku.Add(new Offset("99A2", "1E"));
            offset_rikku.Add(new Offset("98CE", "64"));
            offset_rikku.Add(new Offset("98D0", "64"));
        }
        private void InitPaine()
        {
            offset_paine.Add(new Offset("9C90", "28"));
            offset_paine.Add(new Offset("9C86", "14"));
            offset_paine.Add(new Offset("9C88", "64"));
            offset_paine.Add(new Offset("9C7E", "3C"));
            offset_paine.Add(new Offset("9C80", "46"));
            offset_paine.Add(new Offset("9C82", "50"));
            offset_paine.Add(new Offset("9C84", "78"));
            offset_paine.Add(new Offset("9C8A", "1E"));
            offset_paine.Add(new Offset("9C8C", "28"));
            offset_paine.Add(new Offset("9C8E", "3C"));
            offset_paine.Add(new Offset("A030", "A0"));
            offset_paine.Add(new Offset("9F72", "50"));
            offset_paine.Add(new Offset("A042", "1E"));
            offset_paine.Add(new Offset("9F6E", "64"));
            offset_paine.Add(new Offset("9F70", "64"));
        }


        public DeaFortunata()
        {
            InitYuna();
            InitRikku();
            InitPaine();
        }
    }
}
