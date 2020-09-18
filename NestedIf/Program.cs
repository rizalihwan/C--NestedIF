using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NestedIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                 Program Ke - 1");
            Console.WriteLine("==================================================");
            String nama, sikap,ket;
            int nilai, kehadiran;
            Console.Write("Masukan Nama                = ");
            nama = Console.ReadLine() + "\n";
            Console.Write("Masukan Sikap(baik/kurang)  = ");
            sikap = Console.ReadLine();
            Console.Write("Masukan Nilai Murid(1-100)  = ");
            nilai = int.Parse(Console.ReadLine());
            Console.Write("Masukan kehadiran : (0-100) = ");
            kehadiran = int.Parse(Console.ReadLine());
  
         if (nilai >= 75)
            {
                if (kehadiran >= 90){
                    ket = "Lulus";
                }else{
                    ket = "Lulus Bersyarat";
                }
            }
            else
            {
                if (kehadiran >= 90)
                {
                    ket = "Lulus Dengan Perjanjian Sikap";
                }
                else
                {
                    ket = "Tidak Lulus Dan Perbaikan Sikap";
                }
            }
            if (sikap == "Baik" || sikap ==  "baik")
            {
                if (kehadiran >= 90)
                {
                    ket = "Lulus";
                }
                else
                {
                    ket = "Tidak Lulus";
                }
            }
                 Console.Clear();
                Console.WriteLine("===================================================");
                Console.WriteLine(" Hasil Rekap Siswa SMK WIKRAMA PAPUA 1940 IRIAN JAYA");
                Console.WriteLine("===================================================");
                Console.WriteLine("Nama Siswa      : " + nama);
                Console.WriteLine("Nilai Siswa     : " + nilai);
                Console.WriteLine("Sikap Siswa     : " + sikap);
                Console.WriteLine("Kehadiran Siswa : " + kehadiran + "%");
                Console.WriteLine("KETERANGAN      : " + ket );
                 Console.WriteLine("===================================================");
                 String kep;
                 Console.Write("Mau Lanjut Ke Project Selanjutnya (y/t) : ");
                 kep = Console.ReadLine();
                 if (kep == "y")
                 {
                     Console.Clear();
                 }
                 int  banyak, total, total1, diskon;
                 string member;
                 Console.Write("WELCOME TO UDIN FOTOCOPYAN\n");
                 Console.WriteLine("==========================");
                 Console.Write("Masukan Banyak Fotocopy Anda : ");
                 banyak = int.Parse(Console.ReadLine());
                 Console.Write("Member Atau Bukan(Ya/Tidak) : ");
                 member = Console.ReadLine();
                 if (member == "ya" || member == "Ya" || member == "YA")
                 {
                     if (banyak >= 100)
                     {
                         total1 = (banyak * 500);
                         diskon = (total1 * 12 / 100);
                         total = total1 - diskon;
                     }
                     else
                     {
                         total1 = (banyak * 500);
                         diskon = (total1 * 10 / 100);
                         total = total1 - diskon;
                     }

                 }
                 else
                 {
                     if (banyak >= 150)
                     {
                         total1 = (banyak * 500);
                         diskon = (total1 * 2 / 100);
                         total = total1 - diskon;
                     } 
                     else
                     {
                         total1 = (banyak * 500);
                         diskon = (total1 * 1 / 100);
                         total = total1 - diskon;
                     }
                 }
                 Console.Clear();
                 Console.WriteLine("        Rekap Hasil ");
                 Console.WriteLine("=================================");
                 Console.Write("\nJumlah Fotokopi     : " + banyak);
                 Console.Write("\nTotal Harga         : " + total1);
                 Console.Write("\nPotongan Disc       : " + diskon);
                 Console.WriteLine("\nTotal Keseluruhan   : " + total);
                 Console.WriteLine("=================================");
                 Console.WriteLine("     ~TerimaKasih~");
                 Console.Read();
                }
            }
    }
    
    

