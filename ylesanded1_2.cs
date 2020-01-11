using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Programm
    {
        static void Main(string[] args)
        {
	    //Esimene Ülesanne

            //Console.WriteLine("Kolmega jaguvad arvud 1-100:");
            //int arv = 1;
            //while (arv <= 100)
            //{
            //    if (arv % 3 == 0)
            //        Console.WriteLine(arv);

            //    arv++;
            //}

            //Console.WriteLine("Kolmega jaguvad arvud 1-100:");
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 3 == 0)
            //        Console.WriteLine(i);
            //}

            //Console.ReadLine();




            List<int> numeros = new List<int>();

            Console.WriteLine("Sisesta numbrid, erista need tühikuga (lõpetamiseks ENTER):");

            while (true)
            {
                string line = Console.ReadLine();

                line = line.Trim();

                if (string.IsNullOrEmpty(line))
                    break;

                string[] lineNumeros = line.Split(' ', '\t');

                foreach(var nume in lineNumeros)
                {
                    var numnum = nume.Trim();
                    int num = Convert.ToInt32(numnum);
                    //Console.WriteLine(num.GetType());
                    //Console.WriteLine(num);
                    numeros.Add(num);
                }

                if (lineNumeros != null && lineNumeros.Length > 0)
                {
                    var max = numeros.Max();
                    var min = numeros.Min();
                    var sum = numeros.Sum();
                    Console.WriteLine($"Listi maksimum väärtus on: {max}");
                    Console.WriteLine($"Listi miinimum väärtus on: {min}");
                    Console.WriteLine($"Listis summa on: {sum}");
                }
                    
            }
        }
    }
}