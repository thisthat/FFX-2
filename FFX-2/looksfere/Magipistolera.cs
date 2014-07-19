using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFX_2.looksfere
{
    class Magipistolera : Looksfera
    {
        private void InitYuna()
        {
            offset_yuna.Add(new Offset("8DEC", "14"));
            offset_yuna.Add(new Offset("8DEE", "14"));
            offset_yuna.Add(new Offset("8DF0", "14"));
            offset_yuna.Add(new Offset("8DF2", "14"));
            offset_yuna.Add(new Offset("8DF4", "14"));
            offset_yuna.Add(new Offset("8DF6", "14"));
            offset_yuna.Add(new Offset("8DF8", "14"));
            offset_yuna.Add(new Offset("8DFA", "14"));
            offset_yuna.Add(new Offset("8DFC", "14"));
            offset_yuna.Add(new Offset("8DFE", "14"));
            offset_yuna.Add(new Offset("924C", "1E"));
            offset_yuna.Add(new Offset("9244", "14"));
            offset_yuna.Add(new Offset("9246", "64"));
            offset_yuna.Add(new Offset("8E00", "01"));
            offset_yuna.Add(new Offset("8E02", "01"));
            offset_yuna.Add(new Offset("8E04", "01"));
            offset_yuna.Add(new Offset("8E06", "01"));
            offset_yuna.Add(new Offset("8E08", "01"));
            offset_yuna.Add(new Offset("8E0A", "01"));
            offset_yuna.Add(new Offset("8E0C", "01"));
            offset_yuna.Add(new Offset("8E0E", "01"));
            offset_yuna.Add(new Offset("8E10", "01"));
            offset_yuna.Add(new Offset("8E12", "01"));
            offset_yuna.Add(new Offset("8E14", "01"));
            offset_yuna.Add(new Offset("8E16", "01"));
            offset_yuna.Add(new Offset("8E18", "01"));
            offset_yuna.Add(new Offset("8E1A", "01"));
            offset_yuna.Add(new Offset("8E1C", "01"));
            offset_yuna.Add(new Offset("8E1E", "01"));
        }
        private void InitRikku()
        {
            offset_rikku.Add(new Offset("948C", "14"));
            offset_rikku.Add(new Offset("948E", "14"));
            offset_rikku.Add(new Offset("9490", "14"));
            offset_rikku.Add(new Offset("9492", "14"));
            offset_rikku.Add(new Offset("9494", "14"));
            offset_rikku.Add(new Offset("9496", "14"));
            offset_rikku.Add(new Offset("9498", "14"));
            offset_rikku.Add(new Offset("949A", "14"));
            offset_rikku.Add(new Offset("949C", "14"));
            offset_rikku.Add(new Offset("949E", "14"));
            offset_rikku.Add(new Offset("98EC", "1E"));
            offset_rikku.Add(new Offset("98E4", "14"));
            offset_rikku.Add(new Offset("98E6", "64"));
            offset_rikku.Add(new Offset("94A0", "01"));
            offset_rikku.Add(new Offset("94A2", "01"));
            offset_rikku.Add(new Offset("94A4", "01"));
            offset_rikku.Add(new Offset("94A6", "01"));
            offset_rikku.Add(new Offset("94A8", "01"));
            offset_rikku.Add(new Offset("94AA", "01"));
            offset_rikku.Add(new Offset("94AC", "01"));
            offset_rikku.Add(new Offset("94AE", "01"));
            offset_rikku.Add(new Offset("94B0", "01"));
            offset_rikku.Add(new Offset("94B2", "01"));
            offset_rikku.Add(new Offset("94B4", "01"));
            offset_rikku.Add(new Offset("94B6", "01"));
            offset_rikku.Add(new Offset("94B8", "01"));
            offset_rikku.Add(new Offset("94BA", "01"));
            offset_rikku.Add(new Offset("94BC", "01"));
            offset_rikku.Add(new Offset("94BE", "01"));
        }
        private void InitPaine()
        {
            offset_paine.Add(new Offset("9B2C", "14"));
            offset_paine.Add(new Offset("9B2E", "14"));
            offset_paine.Add(new Offset("9B30", "14"));
            offset_paine.Add(new Offset("9B32", "14"));
            offset_paine.Add(new Offset("9B34", "14"));
            offset_paine.Add(new Offset("9B36", "14"));
            offset_paine.Add(new Offset("9B38", "14"));
            offset_paine.Add(new Offset("9B3A", "14"));
            offset_paine.Add(new Offset("9B3C", "14"));
            offset_paine.Add(new Offset("9B3E", "14"));
            offset_paine.Add(new Offset("9F8C", "1E"));
            offset_paine.Add(new Offset("9F84", "14"));
            offset_paine.Add(new Offset("9F86", "64"));
            offset_paine.Add(new Offset("9B40", "01"));
            offset_paine.Add(new Offset("9B42", "01"));
            offset_paine.Add(new Offset("9B44", "01"));
            offset_paine.Add(new Offset("9B46", "01"));
            offset_paine.Add(new Offset("9B48", "01"));
            offset_paine.Add(new Offset("9B4A", "01"));
            offset_paine.Add(new Offset("9B4C", "01"));
            offset_paine.Add(new Offset("9B4E", "01"));
            offset_paine.Add(new Offset("9B50", "01"));
            offset_paine.Add(new Offset("9B52", "01"));
            offset_paine.Add(new Offset("9B54", "01"));
            offset_paine.Add(new Offset("9B56", "01"));
            offset_paine.Add(new Offset("9B58", "01"));
            offset_paine.Add(new Offset("9B5A", "01"));
            offset_paine.Add(new Offset("9B5C", "01"));
            offset_paine.Add(new Offset("9B5E", "01"));
        }


        public Magipistolera()
        {
            InitYuna();
            InitRikku();
            InitPaine();
        }

    }
}
