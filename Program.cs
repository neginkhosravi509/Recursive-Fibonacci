using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("fibonachi "+n+":");
            PF(0, 1, n);
            Console.ReadKey();
        }
        // متد بازگشتی برای چاپ سری فیبوناچی
        static void PF(int a,int b, int max)
        {
            //شرط پایان بازگشت
            if (a > max)
            return;

            Console.Write(a+" , ");
            // فراخوانی بازگشتی با عدد بعدی
            PF(b, a + b, max);
        }
    }
}
