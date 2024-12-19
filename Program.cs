using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalIfElseAndSwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int elma = 2;
            int armut = 3;
            int cilek = 1;
            int muz = 3;
            int diger = 4;

            Console.WriteLine("Welcome to Dream Greengrocer!");
            Console.WriteLine("Elma = 2 Lira");
            Console.WriteLine("Armut = 3 Lira");
            Console.WriteLine("Cilek = 1 Lira");
            Console.WriteLine("Muz = 3 Lira");
            Console.WriteLine("Diger bütün meyveler = 4 Lira");

            Console.Write("Hangi meyveyi satin almak isterseniz ? (Elma/Armut/Cilek/Muz/Diger): ");
            string choose = Console.ReadLine();
            string chooseLoverCase = choose.ToLower();


            //Eğer sabit değerlere göre karar verecekseniz (örneğin meyve isimleri gibi), switch-case bu tür durumlara daha uygundur. Bu, if-else yapısında gereksiz tekrarları önler ve yalnızca ilgili durumlarla ilgilenmenizi sağlar.

            /*

            if (chooseLoverCase == "elma" || chooseLoverCase == "armut" || chooseLoverCase == "cilek" || chooseLoverCase == "muz" || chooseLoverCase == "diger")
            {
                if (chooseLoverCase == "elma")
                {
                    Console.WriteLine($"Sectiginiz meyve: {elma} Lira");
                }
                else if (chooseLoverCase == "armut")
                {
                    Console.WriteLine($"Sectiginiz meyve: {armut} Lira");

                }
                else if (chooseLoverCase == "cilek")
                {
                    Console.WriteLine($"Sectiginiz meyve: {cilek}  Lira");
                }
                else if (chooseLoverCase == "muz")
                {
                    Console.WriteLine($"Sectiginiz meyve: {muz} Lira");
                }
                else
                {

                    Console.WriteLine($"Sectiginiz meyve: {diger}  Lira");
                }


            }
            */


            switch (chooseLoverCase)
            {
                case "elma":
                    Console.WriteLine($"Sectiginiz meyve: {elma} Lira");
                    break;

                case "armut":
                    Console.WriteLine($"Sectiginiz meyve: {armut} Lira");
                    break;

                case "cilek":
                    Console.WriteLine($"Sectiginiz meyve: {cilek}  Lira");
                    break;
                case "muz":
                    Console.WriteLine($"Sectiginiz meyve: {muz} Lira");
                    break;
                default:
                    Console.WriteLine($"Sectiginiz meyve: {diger}  Lira");
                    break;

            }

            



        }


    }
}
