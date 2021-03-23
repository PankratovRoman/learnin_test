using System;

namespace learnin_test
{

    class Program
    {
        static void Main(string[] args)
        {
            // данный код описывает полиморфизм подтипов на примере жизненной ситуации
            //Pacani[] kakateli = new Pacani[2];
            //kakateli[0] = new Pacani("Витек");
            //kakateli[1] = new Seruni("Мишаня с пятого этажа");
            //foreach (var poci in kakateli)
            //{
            //    poci.ShoditVTubzik();
            //}

            //Parrot popka = new Parrot("Попка", "желтый");
            //Dog tuzik = new Dog("кНоПка", "риджбек", 1.5f);
            //Console.WriteLine(popka);
            //tuzik.Move();

            HeatingSystem boiler = new HeatingSystem("котел", "baxi", 33000f, "газ");
            boiler.StartSystem();
            WaterSupplySystem bathBlender = new WaterSupplySystem("смеситель", "grohe", 7500f, "горячая и холодная", "ванная комната");
            bathBlender.StartSystem();

        }
    }
}
