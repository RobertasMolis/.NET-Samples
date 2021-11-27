using System;
using System.Collections.Generic;
using System.Linq;

namespace UzdaviniaiMasyvai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> names = new List<string>();

            //names.Add("Robertas");
            //names.Add("Vaidas");
            //names.Add("Vytautas");
            //names.Add("Ramūnas");



            //List<string> first = new List<string> { "One", "Two", "Three" };
            //List<string> second = new List<string>() { "Four", "Five" };

            //names.AddRange(first);

            //foreach (string vardas in names)
            //{
            //    console.writeline(vardas);
            //}

            //Console.WriteLine(names.Count);
            //names.Remove("Robertas");
            //Console.WriteLine(names.Count);
            //names.ForEach(vardas => { Console.WriteLine(vardas); });
                
            // 1

            List<int> numbers = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < 30; i++)
            {
                numbers.Add(rand.Next(5, 26));
            }

             numbers.ForEach(num => { Console.WriteLine(num); });

            // 2a

            //int counter = 0;
            //for (int i = 0;i < numbers.Count; i++)
            //{
            //    if(numbers[i] > 10)
            //    {
            //        counter++;
            //    }
            //}


            //Console.WriteLine("Skaičių masyve yra " + counter);

            // 2b

            //int maxValue = 0;

            //List<int> indexes = new List<int>();
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if (numbers[i] > maxValue)
            //    {
            //        maxValue = numbers[i];
            //        indexes.Clear();
            //        indexes.Add(i);
            //    }
            //    if(numbers[i] == maxValue)
            //    {
            //        indexes.Add(i);
            //    }
            //}


            // 2c

            int equalNums = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    numbers[i] = equalNums;
                }
            }

       

            









        }
    }
}
