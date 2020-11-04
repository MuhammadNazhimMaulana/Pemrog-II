using System;

namespace TugasPemrog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jadi ini adalah hasil dari tugas yang telah saya buat mengenai inheritence");

            Person person = new Person() { Umur = 20, NamaLengkap = "Dodi" };
            Console.WriteLine(person.Detail());

            Guru guru = new Guru() { Umur = 40, NamaLengkap = "Pak Iwan", pelajaran = "B. Inggris" };
            Console.WriteLine(guru.Detail());

            Pelajar pelajar = new Pelajar() { Umur = 19, NamaLengkap = "Doni", kelas = 2, sekolah = "SMA" };
            Console.WriteLine(pelajar.Detail());

            Sekolah sekolah = new Sekolah();
            sekolah.pendiri();
        }
    }
}
