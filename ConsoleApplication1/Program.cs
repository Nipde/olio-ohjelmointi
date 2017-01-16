using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottojanimet
{
    class Program
    {
        static void Main(string[] args)
        {
            Nimijarjestaja();
            //Lotto();
        }
        static void Lotto()
        {
            int rowCount = 0;
            Random randomi = new Random();
            Console.WriteLine("Kuinka monta riviä haluat?");

            while (rowCount <= 0)
            {
                int.TryParse(Console.ReadLine(), out rowCount);
            }

            for (int x = 0; x < rowCount; x++)
            {
                int[] numbers = new int[7];
                for (int y = 0; y < 7; y++)
                {
                    bool bChecked = false;
                    while (!bChecked)
                    {
                        int checkNumber = randomi.Next(1, 40);
                        if (Array.IndexOf(numbers, checkNumber) < 0)
                        {
                            numbers[y] = checkNumber;
                            bChecked = true;
                        };
                    }
                }
                string str = "Rivi " + x + ":";

                Array.Sort(numbers);
                str = str + " " + String.Join(", ", numbers);

                Console.WriteLine(str);
            }

            Console.ReadLine();
        }
        static void Nimijarjestaja()
        {
            string annetutnimet = "Lisäsit nimet: ";
            string jarjestetytnimet = "Nimet aakkosjärjestyksessä: ";

            Console.WriteLine("Anna 5 nimeä");
            string[] nimet = new string[5];

            for (int i = 0; i < 5; i++) { nimet[i] = Console.ReadLine(); }

            annetutnimet = annetutnimet + String.Join(" ", nimet);
            Array.Sort(nimet);
            jarjestetytnimet = jarjestetytnimet + String.Join(" ", nimet);


            Console.WriteLine(annetutnimet);
            Console.WriteLine(jarjestetytnimet);
            Console.ReadLine();
        }
    }
}
