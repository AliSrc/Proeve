using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Proeve
{
    class Program
    {

        public static void tastvilkaar()
        {
            Console.WriteLine("Tryk paa en vilkaarlig tast for at komme videre");
            Console.WriteLine("test the new world ");
            Console.WriteLine("Edit recieved! By Ali Sarac");
            Console.WriteLine("Hej med dig");
            Console.ReadKey();
            Console.Clear();
        }

        static int TaelleBogtstav(string value)
        {
            int result = 0;
            bool lastWasSpace = false;

            foreach (char c in value)
            {
                if (char.IsWhiteSpace(c))
                {

                    if (lastWasSpace == false)
                    {
                        result++;
                    }
                    lastWasSpace = true;
                }
                else
                {
                    result++;
                    lastWasSpace = false;
                }
            }
            return result;
        }

        static void Main
        static void Main(string[] args)
        {
            System.Text.Encoding.GetEncoding("ISO-8859-1");

            //Opgave 1
            Console.Write("Julemand eller ej?: ");
            var jule = Console.ReadLine();
            if (jule != null)
            {
                jule = jule.ToLower();
                if (jule == "julemand")
                {
                    Console.WriteLine("Glædelig jul nissemand!");

                }
                else
                {
                    Console.WriteLine("Godt Nytår nissepige!");
                }
            }
            tastvilkaar();


            //Opgave 3
            var tekst = System.IO.File.ReadAllText(@"c:\Hamlet.txt");
            Console.WriteLine(tekst);
            tastvilkaar();

            //Opgave 3A
            int count = tekst.Count(f => f == ' ');
            Console.WriteLine($"Der er {count} ord");
            tastvilkaar();

            //Opgave 3B
            List<string> teks = new List<string>();
            teks = tekst.Split(' ').ToList();


            for (int i = 0; i < teks.Count; i++)
            {
                teks[i].ToLower();
            }

            foreach (var tek in teks)
            {
                if (tek.StartsWith("h"))
                    Console.WriteLine(tek);
            }
            tastvilkaar();

            //Opgave 3C
            Console.WriteLine($"Der er {TaelleBogtstav(tekst)} bogstaver");
            tastvilkaar();


            //Opgave 3D
            var q = from x in teks
                    group x by x into g
                    let counts = g.Count()
                    orderby counts descending
                    select new { Value = g.Key, Count = counts };
            foreach (var x in q)
            {
                Console.WriteLine($"Ord: {x.Value} Forekommer: {x.Count} Antal gane");
            }
            tastvilkaar();


            //Opgave 3E
            var laengste = teks.Aggregate("", (max, cur) => max.Length > cur.Length ? max : cur);
            Console.WriteLine($"Den laengste ord er: {laengste}");
            tastvilkaar();
        }

        /* Opgave 4 
         * 
         * Medlemskap program. 
         * Programmet skal kunne registere ny brugere med Navn, Efternavn, Adresse, Fødselsdato, Registerings Dato.
         * Alle data skal gemmes i Database Der skal kunne indtastet kontingent for medlemmer og alle dat  skal kunne hentes igen.
         * 
         */

    }
}
