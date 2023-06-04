using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktoriyel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı girin :");
            int sayi =Convert.ToInt32(Console.ReadLine());  


            int faktoriyel = 1;
            for(int i=1; i<=sayi; i++) {
                faktoriyel *= i;
            }
            Console.WriteLine("Sayının faktoriyel sonucu :"+faktoriyel);
            Console.ReadLine();
        }
    }
}
