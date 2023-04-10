using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dosen
{
    public class Dosen 
    {
        private int ID;
        private string nama;
        private int Nik;
        private string gender;
        private string course;

        public Dosen()
        {
            this.ID = 1;
            this.nama = "Dosen pengampu";
            this.Nik = 123456789;
            this.gender = "Male";
            this.course = "Pemrograman Berorientasi Objek ";
        }
        void attDosen(string nama, int Nik)
        {
            this.nama = nama;
            this.Nik = Nik;
           
        }
        void addCourse(string course)
        {
            this.course = course;
        }
        void display()
        {
            Console.WriteLine("ID: " + this.ID" Nama: " + this.nama " Nik: ");
            //Console.ReadLine;

        } 
            

    }
}
