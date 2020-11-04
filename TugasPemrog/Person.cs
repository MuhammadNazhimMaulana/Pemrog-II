namespace TugasPemrog
{
    public class Person
    {
        public string NamaLengkap { get; set; }

        public int Umur { get; set; }


        public virtual string Detail() => $"Dia bernama {NamaLengkap} dan umur nya {Umur}";
        public string Detail(double height) => $"Dia bernama {NamaLengkap} dan umur nya {Umur}";
    }
}