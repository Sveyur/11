using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Функция 0=k*x+b");
            Console.Write("Введите k= : ");            
            float k = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите b= : ");
            float b = Convert.ToSingle(Console.ReadLine());
            Function function;
            function.k = k;
            function.b = b;
            function.Root(k, b);
            Console.ReadKey();
        }
        struct Function
        {
           public float k;
           public float b;
            public void Root(float k, float b)
            {

                if (k == 0 && b == 0)
                {
                    Console.WriteLine("x= любое число");
                }
                else if (k == 0)
                {
                    Console.WriteLine("Ошибка!");
                }
                else
                {
                    Console.WriteLine("х= " + -b / k);
                }
            }

        }
    }
}
