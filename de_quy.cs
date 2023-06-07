using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaySo_Fibonacci
{
    internal class de_quy
    {
        public static void in_deQuy()
        {
            /*  in n số fibonacci đầu tiên, bắt đầu từ 0:   0, 1, 1, 2, 3, 5, 8, ...    */

            int n = 0;
            do
            {
                Console.Write("Nhập số nguyên dương n: n = ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);

            if (n <= 2)
                Console.WriteLine((n < 2) ? "0" : "0 1");
            else
            {
                Console.Write("0 1 ");

                for (int i = 3; i <= n; i++)
                {
                    Console.Write(Fib(i) + " ");
                }
            }
        }


        // Ham tinh fib de quy
        public static int Fib(int n)
        {
            if (n <= 2)
                return (n == 1) ? 0 : 1;
            else if (n == 3)
                return 1;
            else return Fib(n - 1) + Fib(n - 2);
        }
    }
}
