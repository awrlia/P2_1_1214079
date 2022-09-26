using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1214079
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Angka Pertama = ");
            int angka1 = int.Parse(Console.ReadLine());

            Console.Write("Angka Kedua = ");
            int angka2 = int.Parse(Console.ReadLine());

            int penjumlahan, pengurangan, pembagian,perkalian;
            penjumlahan = angka1 + angka2;
            pengurangan = angka1 - angka2;
            perkalian = angka1 * angka2;
            pembagian = angka1 / angka2;
            Console.WriteLine("{0} + {1} = {2}", angka1, angka2, penjumlahan);
            Console.WriteLine("{0} - {1} = {2}", angka1, angka2, pengurangan);
            Console.WriteLine("{0} * {1} = {2}", angka1, angka2, perkalian);
            Console.WriteLine("{0} / {1} = {2}", angka1, angka2, pembagian);
        }
    }
}
