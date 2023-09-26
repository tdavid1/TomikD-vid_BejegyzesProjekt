using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomikDávid_BejegyzesProjekt
{
    internal class Bejegyzes
    {
        private string szerzo;
        private string tartalom;
        private int likeok;
        private DateTime letrejot;
        private DateTime szerkesztve;
        private string szerkesztetszoveg;

        public Bejegyzes(string szerzo, string tartalom, DateTime letrejot)
        {
            this.szerzo = szerzo;
            this.tartalom = tartalom;
            this.likeok = 0;
            this.letrejot = letrejot;
        }

        public string Szerzo { get => szerzo;}
        public string Tartalom { get => tartalom; set => tartalom = value; }
        public int Likeok { get => likeok;}
        public DateTime Letrejot { get => letrejot;}
        public DateTime Szerkesztve { get => szerkesztve; }

        public void Like()
        {
            this.likeok++;
        }
        public void szerkesztes(string szoveg)
        {
            szerkesztetszoveg = tartalom;
            this.tartalom = szoveg;
            szerkesztve = DateTime.Now;
        }
        public override string ToString()
        {
            return $"{this.szerzo} - Likeok száma:{this.likeok} - Létrejöt:{this.letrejot} \n{szerkesztve}:{szerkesztetszoveg} \n {tartalom}";
        }
    }
}
