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
            Dog tuzik = new Dog("кНоПка", "риджбек", 1.5f);
            //Console.WriteLine(popka);
            Doctor docJohnKoten = new Doctor();
            docJohnKoten.Examine(tuzik);
            //tuzik.Hit(8);
            //docJohnKoten.Examine(tuzik);
            //tuzik.Hit(20);
            //docJohnKoten.Examine(tuzik);
            //tuzik.LickItself();
            //docJohnKoten.Examine(tuzik);

            //Console.WriteLine(UnicornPig.Zhenek.Name + " + " + UnicornPig.Kapkanec.Name + " = два гомо-синглтона");

            //HeatingSystem boiler = new HeatingSystem("котел", "baxi", 33000f, HeatingResourceType.Gas);
            //boiler.StartSystem();
            //boiler.Pisun = "Zheka";
            //Console.WriteLine(boiler.Pisun);


            //WaterSupplySystem shower = new WaterSupplySystem("душ", "grohe", 50000f, true, true, "ванная комната");
            //shower.StartSystem();
            //WaterSupplySystem bathBlender = new WaterSupplySystem("смеситель", "grohe", 7500f, "горячая и холодная", "ванная комната");
            //WaterSupplySystem citchenBlender = new WaterSupplySystem("смеситель", "grohe", 5300f, "горячая", "кухня");
            //bathBlender.StartSystem();
            //citchenBlender.StartSystem();
            //ElectricitySupplySystem electricPanel = new ElectricitySupplySystem("электрощит", "schneider", 50000f, "черновая");
            //electricPanel.StartSystem();



            //Console.WriteLine("Введите оборудование, которое хотите создать: ");
            //var name = Console.ReadLine();
            //Console.WriteLine("Какого производителя вы предпочитаете?: ");
            //var brand = Console.ReadLine();
            //Console.WriteLine("Смотрели сколько стоит? Скажите: ");
            //var price = float.Parse(Console.ReadLine()); // хуйня
            //Console.WriteLine("Какой водой будете пользоваться?: ");
            //var resourceType = Console.ReadLine();

            //HeatingSystem collector = new HeatingSystem(name, brand, price, resourceType);
            //collector.StartSystem();

        }

    }
}
