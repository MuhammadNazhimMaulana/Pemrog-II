namespace TugasPemrog
{
    public class Guru : Person
    {
        public string pelajaran { get; set; }

        public override string Detail() => $"Dia bernama {NamaLengkap} dan umur nya {Umur}, pelajaran yang di bawakan adalah= {pelajaran}";
    }
}