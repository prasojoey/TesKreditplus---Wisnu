using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KreditPlus
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Soal 1 (Memindahkan nilai variabel a = 5 dan b = 3 tanpa menggunakan variabel tambahan)
            int a = 5;
            int b = 3;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            // Proses pemindahan, di sini saya menggunakan manipulasi aljabar. a = a + b, b = a - b, a = a - b
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("Variabel yang sudah dipindahkan: ");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            //// Soal 2 (Mengurutkan array x dari nilai yang terkecil ke nilai terbesar)
            int[] x = new int[]
            {
                20, 10, 50, 46, 26, 87, 25, 5, 97, 24
            };

            int simpan = 0;

            for (int i=0; i<x.Length;i++)
            {
                for (int j=x.Length-1; j>i; j--)
                {
                    if (x[j] < x[j-1])
                    {
                        simpan = x[j];
                        x[j] = x[j-1];
                        x[j-1] = simpan;
                    }
                }
            }

            Console.WriteLine("Sorted array.");
            for (int i=0; i<x.Length;i++)
            {
                Console.WriteLine(x[i]);
            }
        }
    }
}
