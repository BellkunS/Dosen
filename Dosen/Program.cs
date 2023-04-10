using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dosen
{
    class Program
    {
        static void Main(string[] args)
        {
            Dosen dosen = new Dosen();
            Console.WriteLine("Default Dosen pengampu: ");
            dosen.display();

            Console.WriteLine("\nMasukan Nama dan NIK Dosen Baru: ");
            dosen.attDosen(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
            dosen.display();

            Console.WriteLine("\nMasukan Mata Kuliah Baru: ");
            dosen.attCourse(Console.ReadLine());
            dosen.display();

            Console.ReadLine();

         }
    }
}
