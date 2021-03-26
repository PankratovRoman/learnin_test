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
        // public virtual string Pisun { get; set; } //убери писюн

        protected EngineeringSystems(string name, string brand, float price) //, string pisun = "")
        {
            Name = name;
            Brand = brand;
            Price = price;
            // Pisun = pisun;
        }

        public abstract void StartSystem();
    }

    enum HeatingResourceType
    {
        Gas = 66,
        Electricity = 77
    }
    class HeatingSystem : EngineeringSystems
    {
        ////public new string Name => "pisun"; // стараться такое не использовать
        //private string _heatingPisun;
        //public override string Pisun
        //{
        //    get
        //    {
        //        return base.Pisun + " " + _heatingPisun;
        //    }
        //    set
        //    {
        //        //if (string.IsNullOrEmpty(base.Pisun))
        //        //{
        //        //    base.Pisun = value;
        //        //    return;
        //        //}
        //        _heatingPisun = value;
        //    }
        //}
        ////
        public HeatingResourceType ResourceType { get; set; }
        public string ResourceTypeText
        {
            get
            {
                return ResourceType switch
                {
                    HeatingResourceType.Gas => "газ",
                    HeatingResourceType.Electricity => "электричество",
                    _ => "other",
                };
            }
        }

        public HeatingSystem(string name, string brand, float price, HeatingResourceType resourceType) : base(name, brand, price) //, "bolshoy pisunyara!")
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
                Console.WriteLine($"{Name.Substring(0, 1).ToUpper() + Name[1..].ToLower()} фирмы {Brand} запущен." +
                    $" Данное оборудовани стоило {Price} рублей. Для работы требуется {ResourceTypeText} {(int)ResourceType}.");
            }

        }
    }

    class WaterSupplySystem : EngineeringSystems
    {

        public bool UseHot { get; set; }
        public bool UseCold { get; set; }

        private string _useHotString => UseHot ? "горячей" : "";
        private string _useColdString => UseCold ? "холодной" : "";
        private string _useHotAndCold => UseHot && UseCold ? "и" : "";
        public string IntendedUse { get; set; }

        //return _hotAndCold == "горячая и холодная" ? "горячей и холодной" : _hotAndCold;

        //задание: сделать 2 переменных bool


        public WaterSupplySystem(string name, string brand, float price, bool useHot, bool useCold, string intendedUse) : base(name, brand, price)
        {
            IntendedUse = intendedUse;
            UseHot = useHot;
            UseCold = useCold;

        }
        public override void StartSystem()
        {
            Console.WriteLine($"Установлен и протестирован {Name} фирмы {Brand}. Место установки: {IntendedUse}." +
                $" Предназначен для использования с {_useHotString} {_useHotAndCold} {_useColdString} водой. Стоимость оборудования составила {Price} рублей.");
        }

    }

    class ElectricitySupplySystem : EngineeringSystems
    {
        private string _rougeOrFinishing; // поменять rouge. 
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
            Console.WriteLine($"Установлен {Name} фирмы {Brand}. Стоимость модуля {Price} рублей." +
                $" Используется для {RougeOrFinishing} электромонтажа.");
        }
    }


    //class SewageSystem : EngineeringSystems
    //{
    //    public int PipeDiameter { get; set; }
    //    public override void StartSystem()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}


}
