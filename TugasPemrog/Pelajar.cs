namespace TugasPemrog
{
    public class Pelajar : Person
    {
        public int kelas { get; set; }

        public string sekolah { get; set; }

        public override string Detail() => $"Dia bernama {NamaLengkap} dan umur nya {Umur}, dia sekarang sudah di kelas = {kelas} {sekolah}";
    }
}