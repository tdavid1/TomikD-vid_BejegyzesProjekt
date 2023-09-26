using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TomikDávid_BejegyzesProjekt
{
    internal class Program
    {
        List<Bejegyzes> list = new List<Bejegyzes>();
        List<Bejegyzes> list2 = new List<Bejegyzes>();
        static void Main(string[] args)
        {
            Console.ReadKey();
        }



        public void f2_b()
        {
            Console.Write("Kérlek adjón meg egy számot menyi bejegyzést akkar létrehozni!");
            int szam = int.Parse(Console.ReadLine());
            for (int i = 0; i < szam; i++)
            {
                Console.WriteLine("Kérlek adja meg a szerzot:");
                string szerzo = Console.ReadLine();
                Console.WriteLine("Kérlek adja meg a tartalmat");
                string tartalom = Console.ReadLine();
                DateTime dateTime = DateTime.Now;
                Bejegyzes b = new Bejegyzes(szerzo,tartalom,dateTime);
                list.Add(b);
            }
            f2_c();
        }
        public void f2_c()
        {
            StreamReader sr = new StreamReader("bejegyzesek.csv");
            while (!sr.EndOfStream)
            {
                string[] sor = sr.ReadLine().Split(';');
                string szerzo = sor[0];
                string tartalom = sor[1];
                Bejegyzes b = new Bejegyzes(szerzo, tartalom, DateTime.Now);
                list.Add(b);
            }
        }
    }
}
