using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Zadanie1();
        }
        public static void Zadanie1()
        {
            int[] a = new int[] { 0, 16, 1, 7, 22, 3 };
            int[] b = new int[] { 0, 1, 3, 2 };
            int ob = 0; //колличество одинаковых элементов
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++) // проверка каждого элемента
                {
                    if (a[i] == b[j]) // условия для каждого элемента
                    {
                        ob = ob + 1;
                    }
                }
            }
            Console.WriteLine(ob);
        }
    }
}
