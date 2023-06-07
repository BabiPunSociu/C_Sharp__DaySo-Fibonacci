using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaySo_Fibonacci
{
    internal class vong_lap
    {
        /*  in n số fibonacci đầu tiên, bắt đầu từ 0:   0, 1, 1, 2, 3, 5, 8, ...    */
        public static void in_vongLap()
        {
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

                int firstNumber = 0, secondNumber = 1, nextNumber;

                for(int i=3;i<=n;i++)
                {
                    nextNumber = firstNumber + secondNumber;
                    Console.Write(nextNumber + " ");
                    firstNumber = secondNumber ; secondNumber = nextNumber;
                }
            }
        }
    }
}
