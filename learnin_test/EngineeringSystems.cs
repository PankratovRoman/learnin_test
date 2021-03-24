using System;
using System.Collections.Generic;
using System.Text;

namespace learnin_test
{
    // имеем дом. В доме есть инженерные системы: отопление, водоснабжение, электроснабжение
    // каждая система имеет экземпляры оборудования

    abstract class EngineeringSystems
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public float Price { get; set; }

        protected EngineeringSystems()
        {
        }

        protected EngineeringSystems(string name, string brand, float price)
        {
            Name = name;
            Brand = brand;
            Price = price;
        }

        public abstract void StartSystem();


    }

    class HeatingSystem : EngineeringSystems
    {
        public string ResourceType { get; set; }

        public HeatingSystem(string resourceType = null) : base()
        {
            ResourceType = resourceType;
        }

        public HeatingSystem(string name, string brand, float price, string resourceType) : base(name, brand, price)
        {
            ResourceType = resourceType;
        }

        public override void StartSystem()
        {
            if (Name is null)
            {
                Console.WriteLine("Создайте элемент корректно");
            }
            else
            {
                Console.WriteLine($"{Name.Substring(0, 1).ToUpper() + Name.Substring(1).ToLower()} фирмы {Brand} запущен." +
                    $" Данное оборудовани стоило {Price} рублей. Для работы требуется {ResourceType} вода.");
            }

        }
    }

    class WaterSupplySystem : EngineeringSystems
    {
        private string _hotAndCold;
        public string HotAndCold
        {
            get
            {
                //return _hotAndCold == "горячая и холодная" ? "горячей и холодной" : _hotAndCold;
                switch (_hotAndCold)
                {
                    case "горячая и холодная":
                        return "горячей и холодной";
                    case "горячая":
                        return "горячей";
                    case "холодная":
                        return "холодной";
                    default:
                        return _hotAndCold;
                }

            }
            set
            {
                _hotAndCold = value;
            }
        }
        public string IntendedUse { get; set; }
        public WaterSupplySystem(string name, string brand, float price, string hotAndCold, string intendedUse) : base(name, brand, price)
        {
            HotAndCold = hotAndCold;
            IntendedUse = intendedUse;
        }
        public override void StartSystem()
        {
            Console.WriteLine($"Установлен и протестирован {Name} фирмы {Brand}. Место установки: {IntendedUse}." +
                $" Предназначен для использования с {HotAndCold} водой. Стоимость оборудования составила {Price} рублей.");
        }

    }

    class ElectricitySupplySystem : EngineeringSystems
    {
        private string _rougeOrFinishing;
        public string RougeOrFinishing
        {
            get
            {
                return _rougeOrFinishing switch //аналог свича, определенного в свойстве вышел. Предложила студия.
                {
                    "черновая" => "чернового",
                    "чистовая" => "чистового",
                    _ => _rougeOrFinishing,
                };
            }
            set
            {
                _rougeOrFinishing = value;

            }
        }
        public ElectricitySupplySystem(string name, string brand, float price, string rougeOrFinishing) : base(name, brand, price)
        {
            RougeOrFinishing = rougeOrFinishing;
        }


        public override void StartSystem()
        {
            Console.WriteLine($"Установлен {Name} фирмы {Brand}. Стоимость модуля {Price} рублей. Используется для {RougeOrFinishing} электромонтажа.");
        }
    }


    //class SewerageSystem : EngineeringSystems
    //{
    //    public int PipeDiameter { get; set; }
    //    public override void StartSystem()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}


}
