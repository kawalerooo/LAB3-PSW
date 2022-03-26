using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj dlugosc tablicy:");
            String dlugosctablicy = Console.ReadLine();
            int dlugosctab;
            dlugosctab = int.Parse(dlugosctablicy);
            double[] tablica;
            tablica = new double[dlugosctab];
            Random rand = new Random();
            double[] liczby = { 2, 3, 3.5, 4, 4.5, 5 };
            int i;

            for (i = 0; i < dlugosctab; i++)
            {
                tablica[i] = liczby[rand.Next(liczby.Length)];
            }
            double wyniksumy = 0;

            for (i = 0; i < dlugosctab; i++)
            {
                wyniksumy = wyniksumy + tablica[i];
            }

            for (int j = 0; j < dlugosctab; j++)
            {
                System.Console.WriteLine(tablica[j]);
            }

            double srednia = wyniksumy / dlugosctab;
            Console.WriteLine("Średnia: " + srednia);
            double min;
            min = tablica[0];
            for (int x = 0; x < tablica.Length; x++)
            {
                if (min > tablica[x])
                {
                    min = tablica[x];
                }
            }
            System.Console.WriteLine("Najmniejsza wartosc to:" + min);

            double max;
            max = tablica[0];
            for (int x = 0; x < tablica.Length; x++)
            {
                if (max < tablica[x])
                {
                    max = tablica[x];
                }
            }
            System.Console.WriteLine("Najwieksza wartosc to:" + max);

            double[] tab;
            tab = new double[dlugosctab];
            int y = 0;
            for (int g = 0; g < tablica.Length; g++)
            {
                if (tablica[g] < srednia)
                {
                    tab[y] = tablica[g];
                    y++;
                }
            }


            System.Console.WriteLine("Wartosci nizsze niz srednia:");
            for (int z = 0; z < tab.Length; z++)
            {
                if (tablica[z] < srednia)
                    System.Console.WriteLine(tablica[z]);
            }



            int t = 0;
            for (int d = 0; d < tablica.Length; d++)
            {
                if (tablica[d] > srednia)
                {
                    tab[t] = tablica[d];
                    t++;
                }
            }
            System.Console.WriteLine("Wartosci wyzsze niz srednia:");
            for (int o = 0; o < tab.Length; o++)
            {
                if (tablica[o] > srednia)
                    System.Console.WriteLine(tablica[o]);
            }

            for (int v = 0; v < tablica.Length; v++)
            {
                tablica[v] = Math.Pow(tablica[v], 2);
            }

            double wyniksumypotegi = 0;
            for (int u = 0; u < tablica.Length; u++)
            {
                wyniksumypotegi = wyniksumypotegi + tablica[u];
            }
            double wynikdzielenia = wyniksumypotegi / tablica.Length;
            double wynikwariancji = wynikdzielenia - (Math.Pow(srednia, 2));
            double wynikodchylenia = Math.Sqrt(wynikwariancji);
            System.Console.WriteLine("Wynik odchylenia:" + wynikodchylenia);
            Console.ReadKey();
        }
    }
