using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaySo_Fibonacci
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // in day n số fibonacci đầu tiên theo vong lap
            vong_lap.in_vongLap();

            Console.WriteLine();    // xuống dòng

            // in day n số fibonacci đầu tiên theo đệ quy
            de_quy.in_deQuy();
        }
    }
}
