using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            Console.WriteLine("Pilih menu Calculator : \n");

            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Penguarangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian\n");

            int input;

            Console.Write("Input nomer menu [1..4]: ");
            input = Convert.ToInt32(Console.ReadLine());

            if (input == 1)
            {
                Console.Write("\nInputkan Nilai A = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan Nilai B = ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("");
                Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
                Console.WriteLine("\nTekan Sembarang untuk Keluar");

            }

            else if (input == 2)
            {
                Console.Write("\nInputkan Nilai A = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan Nilai B = ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("");
                Console.WriteLine("Hasil Pengurangan " + a + " - " + b + " = " + Pengurangan(a, b));
                Console.WriteLine("\nTekan Sembarang untuk Keluar");
            }

            else if (input == 3)
            {
                Console.Write("\nInputkan Nilai A = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan Nilai B = ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("");
                Console.WriteLine("Hasil Perkalian " + a + " x " + b + " = " + Perkalian(a, b));
                Console.WriteLine("\nTekan Sembarang untuk Keluar");
            }

            else if (input == 4)
            {
                Console.Write("\nInputkan Nilai A = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan Nilai B = ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("");
                Console.WriteLine("Hasil Pembagian " + a + " x " + b + " = " + Pembagian(a, b));

                Console.WriteLine("\nTekan Sembarang untuk Keluar");
            }

            else
            {
                Console.WriteLine("\nMaaf, Menu yang Anda pilih tidak tersedia");
                Console.WriteLine("\nTekan Sembarang untuk Keluar");
            }
        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}

//Credit goes to Ade Indra Yudha Pratama [20.11.3341]