using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_105
{
    class BubbleShort
    {

    }
    internal class program
    {
        // Deklarasi array int dengan ukuran 25
        private int[] Bril = new int[25];

        // Deklarasi variabel int untuk menyimpan banyaknya data pada array
        private int n;

        // Fungsi / Method untuk menerima masukan
        public void read()
        {
            // Menerima angka untuk menentukan banyaknya data yang disimpan pada array
            while (true)
            {
                Console.Write("Masukan banyaknya elemen pada Array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 25)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 20 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Masukan elemen array ");
            Console.WriteLine("-----------------------");

            // Pengguna memasukan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + "> ");
                string s1 = Console.ReadLine();
                Bril[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            // Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Element array yang telah tersusun");
            Console.WriteLine("---------------------------------");
            for (int BF = 0; BF < n; BF++)
            {
                Console.WriteLine(Bril[BF]);
            }
            Console.WriteLine("");
        }
        public void BubbleSortArray()
        {
            for (int i = 1; i < n; i++) // for n - 2 passes
            {
                // Pada pass i,bandingkan n - i elemen pertama dengan elemen
                for (int BF = 0; BF < n - i; BF++)
                {
                    if (Bril[BF] > Bril[BF + 1]) // Jika elemen tidak dalam urutan yang benar
                    {
                        // Tukar elemen
                        int temp;
                        temp = Bril[BF];
                        Bril[BF] = Bril[BF + 1];
                        Bril[BF + 1] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            // Creating the object of the BubbleSort class
            program mylist = new program();

            // Pemanggilan funsi untuk menerima elemen array
            mylist.read();

            // Pemanggilan fungsi untuk mengurutkan array
            mylist.BubbleSortArray();

            // Pemanggilan fungsi untuk menampilkan array yang tersusun
            mylist.display();

            // Exit
            Console.WriteLine("\n\nTekan Tombol Apa Saja Untuk Keluar. ");
            Console.Read();
        }
    }
}
