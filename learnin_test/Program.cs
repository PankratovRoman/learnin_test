using System;

namespace learnin_test
{
    class Pacani
    {
        public string name;
        public virtual void ShoditVTubzik()
        {
            Console.WriteLine("{0} пошел покакать!", name);
        }
    }

    class Seruni : Pacani
    {
        public override void ShoditVTubzik()
        {
            Console.WriteLine("{0} - ебучий серун! Опять засрал весь унитаз!", name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pacani[] kakateli = new Pacani[2];
            Pacani vitek = new Pacani();
            vitek.name = "Витек";
            Seruni misha = new Seruni();
            misha.name = "Мишаня с пятого этажа";
            kakateli[0] = vitek;
            kakateli[1] = misha;
            foreach (var poci in kakateli)
            {
                poci.ShoditVTubzik();
            }
        }
    }
}
