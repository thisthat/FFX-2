using FFX_2.looksfere;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFX_2.Looksfere
{
    class Mascotte : Looksfera
    {
        private void InitYuna()
        {
            offset_yuna.Add(new Offset("8F62", "28"));
            offset_yuna.Add(new Offset("8F52", "0A"));
            offset_yuna.Add(new Offset("8F54", "0A"));
            offset_yuna.Add(new Offset("8F56", "0A"));
            offset_yuna.Add(new Offset("8F58", "0A"));
            offset_yuna.Add(new Offset("8F5A", "28"));
            offset_yuna.Add(new Offset("8F5C", "28"));
            offset_yuna.Add(new Offset("8F5E", "28"));
            offset_yuna.Add(new Offset("8F60", "28"));
            offset_yuna.Add(new Offset("8F64", "50"));
            offset_yuna.Add(new Offset("92DE", "03E7"));
            offset_yuna.Add(new Offset("92E4", "50"));
            offset_yuna.Add(new Offset("92E6", "50"));
            offset_yuna.Add(new Offset("8DAE", "50"));
            offset_yuna.Add(new Offset("8DB2", "50"));
        }
        private void InitRikku()
        {
            offset_rikku.Add(new Offset("9606", "0A"));
            offset_rikku.Add(new Offset("9608", "0A"));
            offset_rikku.Add(new Offset("960A", "0A"));
            offset_rikku.Add(new Offset("960C", "0A"));
            offset_rikku.Add(new Offset("960E", "28"));
            offset_rikku.Add(new Offset("9610", "28"));
            offset_rikku.Add(new Offset("9612", "28"));
            offset_rikku.Add(new Offset("9614", "28"));
            offset_rikku.Add(new Offset("9616", "28"));
            offset_rikku.Add(new Offset("9618", "50"));
            offset_rikku.Add(new Offset("997E", "03E7"));
            offset_rikku.Add(new Offset("9984", "50"));
            offset_rikku.Add(new Offset("9986", "50"));
            offset_rikku.Add(new Offset("9454", "50"));
            offset_rikku.Add(new Offset("9458", "50"));
        }
        private void InitPaine()
        {
            offset_paine.Add(new Offset("9CBA", "0A"));
            offset_paine.Add(new Offset("9CBC", "0A"));
            offset_paine.Add(new Offset("9CBE", "0A"));
            offset_paine.Add(new Offset("9CC0", "0A"));
            offset_paine.Add(new Offset("9CC2", "0A"));
            offset_paine.Add(new Offset("9CC4", "14"));
            offset_paine.Add(new Offset("9CC6", "14"));
            offset_paine.Add(new Offset("9CC8", "14"));
            offset_paine.Add(new Offset("9CCA", "1E"));
            offset_paine.Add(new Offset("9CCC", "50"));
            offset_paine.Add(new Offset("A01E", "03E7"));
            offset_paine.Add(new Offset("A024", "50"));
            offset_paine.Add(new Offset("A026", "50"));
            offset_paine.Add(new Offset("9AF0", "50"));
            offset_paine.Add(new Offset("9AF6", "50"));
        }


        public Mascotte()
        {
            InitYuna();
            InitRikku();
            InitPaine();
        }
    }
}
