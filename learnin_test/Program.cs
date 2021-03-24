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
            WaterSupplySystem citchenBlender = new WaterSupplySystem("смеситель", "grohe", 5300f, "горячая", "кухня");
            bathBlender.StartSystem();
            citchenBlender.StartSystem();
            ElectricitySupplySystem electricPanel = new ElectricitySupplySystem("электрощит", "schneider", 50000f, "черновая");
            electricPanel.StartSystem();

            HeatingSystem collector = new HeatingSystem();
            collector.StartSystem();
            Console.WriteLine("Введите оборудование, которое хотите создать: ");
            collector.Name = Console.ReadLine();
            Console.WriteLine("Какого производителя вы предпочитаете?: ");
            collector.Brand = Console.ReadLine();
            Console.WriteLine("Смотрели сколько стоит? Скажите: ");
            collector.Price = float.Parse(Console.ReadLine()); // хуйня
            Console.WriteLine("Какой водой будете пользоваться?: ");
            collector.ResourceType = Console.ReadLine();
            collector.StartSystem();
            


        }

    }
}
