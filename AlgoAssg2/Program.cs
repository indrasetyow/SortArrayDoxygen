using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoAssg2
{

    /// <summary>
    /// main class
    /// </summary>
    /// <remarks>class program dapat membuat operasi sortir array secara berurutan</remarks>
    class Program
    {
       
        private int[] Indra = new int[20];
        
        private int n;

        /// <summary>
        /// <para name="input">untuk memasukkan nilai</para>
        /// <param name="masuk">untuk menginput banyaknya data yang akan diinput</param>
        /// <param name="masukarr">untuk menginput data ke dalam array</param>
        /// input data
        /// </summary>
        public void input()
        {
            while (true)
            {
                Console.Write("Masukkan Banyak Elemen pada Array : ");
                string masuk = Console.ReadLine();
                n = Int32.Parse(masuk);
                if (n <= 20)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nMaksimal Array 20 Elemen! \n");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Masukkan elemen array ");
            Console.WriteLine("");

            for (int i = 0; i < n; i++)
            {
                Console.Write("{" + (i + 1) + "}. ");
                string masukArr = Console.ReadLine();
                Indra[i] = Int32.Parse(masukArr);
            }
        }
        /// <summary>
        /// <para name="sortArr">untuk memasukkan nilai</para>
        /// <param name="temp">untuk penyimpanan data sementara</param>
        /// <param name="min_index">untuk mengatur minimal nilai yang bisa diinput</param>
        /// </summary>
        public void sortArr()
        {
            int temp, min_index;
            for (int min = 0; min < n - 1; min++)
            {
                min_index = min;
                for (int j = min + 1; j < n; j++)
                {
                    if (Indra[j] < Indra[min_index])
                    {
                        min_index = j;
                    }
                }
                temp = Indra[min_index];
                Indra[min_index] = Indra[min];
                Indra[min] = temp;
            }
        }
        /// <summary>
        /// <para name="tampil">untuk memasukkan nilai</para>
        /// menampilkan seluruh data array yang sudah tersimpan temporary
        /// </summary>
        public void tampil()
        {
            Console.WriteLine("");
            Console.WriteLine("----------------------------");
            Console.WriteLine(" Elemen array yang tersusun ");
            Console.WriteLine("----------------------------");
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(Indra[j]);
            }
            Console.WriteLine(" ");

        }

        /// <summary>
        /// sub class Program
        /// <param name="input">membuat parameter untuk dibaca di class input untuk menginpukan data array</param>
        /// <param name="sortArr">membuat parameter untuk dibaca di class sortArr untuk mengurutkan data array yang telah diinputkan</param>
        /// <param name="tampil">membuat parameter untuk dibaca di class tampil untuk menampilkan data array</param>
        /// </summary>

        static void Main(string[] args)
        {
            Program prgst = new Program();
            prgst.input();
            prgst.sortArr();
            prgst.tampil();

            Console.WriteLine("\n\nTekan Tombol Apa saja Untuk Keluar. ");
            Console.Read();
        }
    }
}
