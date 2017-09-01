using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание6
{
    class Program
    {
        public static int Imput()//Ввод чисел
        {
            bool rightValue;
            int value;

            do
            {
                string userImput = Console.ReadLine();
                rightValue = int.TryParse(userImput, out value);
                if (!rightValue) Console.Write(@"Ожидалось число. Повторите ввод - ");
            }
            while (!rightValue);

            return value;
        }

        public static void Rec(int m, int n, ref List<int> list)//Рекурсивная функция
        {
            if (n > 2)//Условие для n>3
            {
                if (list.Last() < m)
                {
                    list.Add(list[list.Count - 1] * list[list.Count - 2] + list[list.Count - 3]);
                    n++;
                    Rec(m, n, ref list);
                }
            }
            else//Условия для n<=3
            {
                Console.Write(@"Введите {0} эл-т: ", list.Count + 1);
                list.Add(Imput());
                n++;
                Rec(m, n, ref list);
            }

                   
        }

        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int n = 0;
            Console.Write(@"Введите M: ");
            int m = Imput();

            Rec(m, n, ref list);

            if (list.Last() >= m)//Вывод рез-ов
            {
                foreach (int x in list)
                    Console.Write(x + " ");

                Console.WriteLine();

                if (list.Last() == m)
                    Console.WriteLine("a-n == M");
                else
                    Console.WriteLine("a-n <> M");
            }   

            Console.WriteLine("N - " + list.Count);
            Console.ReadLine();
        }
    }
}
