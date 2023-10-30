using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_NullableType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //nullable and non - non-nullable types //

            // int = non nullable
            // int? = nullable
            string name1 = "jayesh";
            Console.WriteLine(name1);

            int? k = null;
            int l = k ?? 2 ;
            Console.WriteLine($" k : {k} l : {l} ");

            int ? k2  = null; //or values 4
            int l2 = k2 ?? 4 ;
            Console.WriteLine($" k2 : {k2}  l2 : {l2} ");

            string email = "jayeshmalache1@gmail.com";
            string emailUppercase = email.ToUpper() ;   
            Console.WriteLine($" email ; {email} emailUppercase : {emailUppercase } ")


           

          


            Console.ReadLine();
        }
    }
}
