using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFX_2.looksfere
{
    class Biancarcano : Looksfera
    {
        private void InitYuna()
        {
            offset_yuna.Add(new Offset("8ED2", "0A"));
            offset_yuna.Add(new Offset("8ED4", "14"));
            offset_yuna.Add(new Offset("8ED6", "14"));
            offset_yuna.Add(new Offset("8ED8", "28"));
            offset_yuna.Add(new Offset("8EDA", "50"));
            offset_yuna.Add(new Offset("8EDC", "50"));
            offset_yuna.Add(new Offset("8EDE", "14"));
            offset_yuna.Add(new Offset("8EE0", "1E"));
            offset_yuna.Add(new Offset("8EE2", "1E"));
            offset_yuna.Add(new Offset("8EE4", "A0"));
            offset_yuna.Add(new Offset("8EE6", "1E"));
            offset_yuna.Add(new Offset("8EE8", "1E"));
            offset_yuna.Add(new Offset("8EEA", "1E"));
            offset_yuna.Add(new Offset("8EEC", "50"));
            offset_yuna.Add(new Offset("9254", "28"));
            offset_yuna.Add(new Offset("9256", "3C"));
        }
        private void InitRikku()
        {
            offset_rikku.Add(new Offset("9572", "0A"));
            offset_rikku.Add(new Offset("9574", "14"));
            offset_rikku.Add(new Offset("9576", "14"));
            offset_rikku.Add(new Offset("9578", "28"));
            offset_rikku.Add(new Offset("957A", "50"));
            offset_rikku.Add(new Offset("957C", "50"));
            offset_rikku.Add(new Offset("957E", "14"));
            offset_rikku.Add(new Offset("9580", "1E"));
            offset_rikku.Add(new Offset("9582", "1E"));
            offset_rikku.Add(new Offset("9584", "A0"));
            offset_rikku.Add(new Offset("9586", "1E"));
            offset_rikku.Add(new Offset("9588", "1E"));
            offset_rikku.Add(new Offset("958A", "1E"));
            offset_rikku.Add(new Offset("958C", "50"));
            offset_rikku.Add(new Offset("98F4", "28"));
            offset_rikku.Add(new Offset("98F6", "3C"));
        }
        private void InitPaine()
        {
            offset_paine.Add(new Offset("9C12", "0A"));
            offset_paine.Add(new Offset("9C14", "14"));
            offset_paine.Add(new Offset("9C16", "14"));
            offset_paine.Add(new Offset("9C18", "28"));
            offset_paine.Add(new Offset("9C1A", "50"));
            offset_paine.Add(new Offset("9C1C", "50"));
            offset_paine.Add(new Offset("9C1E", "14"));
            offset_paine.Add(new Offset("9C20", "1E"));
            offset_paine.Add(new Offset("9C22", "1E"));
            offset_paine.Add(new Offset("9C24", "A0"));
            offset_paine.Add(new Offset("9C26", "1E"));
            offset_paine.Add(new Offset("9C28", "1E"));
            offset_paine.Add(new Offset("9C2A", "1E"));
            offset_paine.Add(new Offset("9C2C", "50"));
            offset_paine.Add(new Offset("9F94", "28"));
            offset_paine.Add(new Offset("9F96", "3C"));
        }


        public Biancarcano()
        {
            InitYuna();
            InitRikku();
            InitPaine();
        }
    }
}
