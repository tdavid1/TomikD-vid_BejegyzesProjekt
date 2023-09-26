using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomikDávid_BejegyzesProjekt
{
    internal class Feladatok
    {
        List<Bejegyzes> list = new List<Bejegyzes>();
        List<Bejegyzes> list2 = new List<Bejegyzes>();
        public Feladatok() 
        {
            f2();
        }
        private void f2()
        {
            Console.Write("Kérlek adjón meg egy számot menyi bejegyzést akkar létrehozni!");
            int szam = int.Parse(Console.ReadLine());
            if (szam < 0)
            {
                Console.WriteLine("A szám nem természetes szám ezzért nem müködik");
            }
            else
            {
                for (int i = 0; i < szam; i++)
                {
                    Console.WriteLine("Kérlek adja meg a szerzot:");
                    string szerzo = Console.ReadLine();
                    Console.WriteLine("Kérlek adja meg a tartalmat");
                    string tartalom = Console.ReadLine();
                    DateTime dateTime = DateTime.Now;
                    Bejegyzes b = new Bejegyzes(szerzo, tartalom, dateTime);
                    list.Add(b);
                }
            }
            f2_c();
            f2_d();
            f2_e();
            f2_f();
        }
        private void f2_c()
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
        private void f2_d()
        {
            Random r = new Random();
            for (int i = 0; i < list.Count*20; i++)
            {
                list[r.Next(0, list.Count)].Like();
            }
        }
        private void f2_e()
        {
            Console.WriteLine("Kérlek adja hogy mire modositjuk a szöveget.");
            string tartalom = Console.ReadLine();
            list[2].szerkesztes(tartalom);

        }
        private void f2_f()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        private void f3()
        {
            f3_a();
        }
        private void f3_a()
        {
            int seged = 0;
            foreach(var item in list)
            {
                if (seged < item.Likeok)
                {
                    seged = item.Likeok;
                }
            }
            Console.WriteLine($"A legtőbb likeal rendelkező bejegyzésnek likeok száma: {seged}");
        }
    }
}
