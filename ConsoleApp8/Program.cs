using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            // метод Степень
            float Step(float osn, int nn)
            {
                float st = 1;
                for (int i = 1; i <= nn; i++)
                { st = st * osn; }
                return st;
            }
            // метод Сумма
            float Summa(float[] mas)
            {
                float sum = 0;
                for (int i = 0; i < mas.Length; i++)
                {
                    sum = sum + mas[i];
                }
                return sum;
            }
            // ввод массива x
            Console.Write("Введите число элементов x-массива n =");
            int n = Convert.ToInt32(Console.ReadLine());
            float[] x = new float[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите x[{i + 1}] =");
                x[i] = Convert.ToInt32(Console.ReadLine());
            }
            //ввод массива y
            Console.Write("Введите число элементов y-массива m =");
            int m = Convert.ToInt32(Console.ReadLine());
            float[] y = new float[m];
            for (int j = 0; j < m; j++)
            {
                Console.Write($"Введите y[{j + 1}] =");
                y[j] = Convert.ToInt32(Console.ReadLine());
            }
            //ввод y и c
            Console.Write("c =");
            int c = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                x[i] = Step((x[i] - c), n);
            }
            for (int j = 0; j < m; j++)
            {
                y[j] = y[j] / Step(c, m);
            }
            // вызов методов (функций)
            float s = Summa(x) + Summa(y);
            Console.WriteLine($"S={s}");

        }
    }
}
