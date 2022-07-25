using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patik_cSharp_odev_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 4;
            y = y + 2;
            Console.WriteLine(y);

            y /= 2;
            Console.WriteLine(y);
            

            bool isSuccess = true;
            bool isCompleted = false;
            if (isSuccess && isCompleted)
                Console.WriteLine("Perfoct");

            if (isSuccess || isCompleted)
                Console.WriteLine("Great");

            if (isSuccess && !isCompleted)
                Console.WriteLine("Fine");

            int a = 3;
            int b = 4;
            bool sonuc = a < b;

            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);

            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 * sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1++;
            Console.WriteLine(sonuc1);

            int sonuc2 = 20 % 3;
            Console.WriteLine(sonuc2);  



            Console.ReadLine();

        }
    }
}
