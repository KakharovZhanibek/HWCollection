using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWCollection
{
    class Program
    {
        public static void SecMax()
        {
            List<int> numbers = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(rnd.Next(-10, 11));
                Console.Write(" " + numbers[i]);
            }
            numbers.RemoveAt(numbers.IndexOf(numbers.Max()));
            Console.WriteLine("\n____________");
            Console.WriteLine("Второй максимальный : " + numbers.Max());
        }
        public static void DelNechet()
        {
            List<int> numbers = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(rnd.Next(-10, 11));
                Console.Write(" " + numbers[i]);
                if (i % 2 != 0)
                {
                    numbers[i] = 777;
                }
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 777)
                {
                    numbers.RemoveAt(i);
                }
            }
            Console.WriteLine("\n_________________\nУдаление нечетных индексов :\n");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(" " + numbers[i]);
            }
        }
        public static void SredAr()
        {
            List<double> numbers = new List<double>();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                string Num = "0,";
                Num += rnd.Next(1, 100).ToString();
                double d = double.Parse(Num);
                numbers.Add(rnd.Next(0, 15) + d);
                Console.WriteLine(" " + numbers[i]);
            }
            Console.WriteLine("__________________\nСреднее арифметическое :"+numbers.Sum()/numbers.Count+"\n__________________\nБольше среднего арифметического");
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > numbers.Sum() / numbers.Count)
                {
                    Console.WriteLine(" " + numbers[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("№1------------------\n\n");
            SecMax();
            Console.WriteLine("\n\n-------------------\n\n");
            Console.WriteLine("№2------------------\n\n");
            DelNechet();
            Console.WriteLine("\n\n-------------------\n\n");
            Console.WriteLine("№3------------------\n\n");
            SredAr();
            Console.WriteLine("\n\n-------------------\n\n");
        }
    }
}
