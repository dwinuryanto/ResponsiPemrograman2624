using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace responsi
{
    class karyawan
    {
        public string nama1 { get; set; }
        public string nik1 { get; set; }
        public int gaji1 { get; set; }
        public string nama2 { get; set; }
        public string nik2 { get; set; }
        public int gaji2 { get; set; }
        public void infoGaji()
        {
            Console.WriteLine("No\tNim/Nama\t\tGaji");
            Console.WriteLine("=======================================");
            Console.WriteLine("1\t{0}\t{1}\t\t{2}", nik1, nama1, gaji1);
            Console.WriteLine("2\t{0}\t{1}\t\t{2}", nik2, nama2, gaji2);
        }
        public void kenaikanGaji()
        {
            if (gaji1 < 0)
            {
                gaji1 = 0;
            }
            else if (gaji2 < 0)
            {
                gaji2 = 0;
            }
            Console.WriteLine("\nasiikkk gaji naik 10%");
            Console.WriteLine("\nNo\tNik/Nama\t\tGaji");
            Console.WriteLine("=======================================");
            Console.WriteLine("1\t{0}\t{1}\t\t{2}", nik1, nama1, gaji1 + (gaji1 * 0.1));
            Console.WriteLine("2\t{0}\t{1}\t\t{2}", nik2, nama2, gaji2 + (gaji2 * 0.1));
        }
    }
}