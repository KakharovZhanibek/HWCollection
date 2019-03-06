using System;
using System.Collections.Generic;
using System.IO;
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
            Console.WriteLine("__________________\nСреднее арифметическое :" + numbers.Sum() / numbers.Count + "\n__________________\nБольше среднего арифметического");
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > numbers.Sum() / numbers.Count)
                {
                    Console.WriteLine(" " + numbers[i]);
                }
            }
        }
        public static void ReverseLetters()
        {
            string path;
            char[] res; char[] temp;
            Console.WriteLine("Введите путь к файлу");
            path = Console.ReadLine();
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    temp = sr.ReadToEnd().ToCharArray();
                    res = new char[temp.Length];
                }
                for (int i = 0; i < temp.Length; i++)
                {
                    Console.Write("{0} ", temp[i]);
                }
                Console.WriteLine("\n___________________");

                int x = temp.Length - 1;
                for (int i = 0; i < temp.Length; i++)
                {
                    res[i] = temp[x];
                    x--;
                }

                for (int i = 0; i < res.Length; i++)
                {
                    Console.Write("{0} ", res[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

       /* public static void VowelsFirst()
        {
            string path;
            string temp;

            Queue<string> Vowels = new Queue<string>();
            Queue<string> Consonants = new Queue<string>();

            Console.WriteLine("Введите путь к файлу");
            path = Console.ReadLine();

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    temp = sr.ReadToEnd();
                    temp.ToLower();
                }
                Vowels.SelectMany(n => n
                .Split()
                .Where(x => x.StartsWith("a") || x.StartsWith("e") || x.StartsWith("i") || x.StartsWith("o") || x.StartsWith("u")));

                Consonants.SelectMany(n => n
                .Split()
                .Where(x => x.StartsWith("b") || x.StartsWith("c") || x.StartsWith("d") || x.StartsWith("f") || x.StartsWith("g")
                || x.StartsWith("h") || x.StartsWith("j") || x.StartsWith("k") || x.StartsWith("l") || x.StartsWith("m")
                || x.StartsWith("n") || x.StartsWith("p") || x.StartsWith("q") || x.StartsWith("r") || x.StartsWith("s")
                || x.StartsWith("t") || x.StartsWith("v") || x.StartsWith("w") || x.StartsWith("x") || x.StartsWith("y")
                || x.StartsWith("z")));

                Console.WriteLine("\n\n");
                Console.WriteLine(string.Join(" ", Vowels));
                Console.WriteLine(string.Join(" ", Consonants));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }*/
        

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
            Console.WriteLine("№4------------------\n\n");
            ReverseLetters();
        }
    }
}
