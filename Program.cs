using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsi
{
    class Program
    {
        static void Main(string[] args)
        {
            karyawan krw = new karyawan
            {
                nama1 = "dwi",
                nik1 = "2624",
                gaji1 = 3000000,

                nama2 = "saputro",
                nik2 = "2555",
                gaji2 = 2000000
            };

            krw.infoGaji();
            Console.WriteLine();
            krw.kenaikanGaji();
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}