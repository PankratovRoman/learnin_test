using System;
using System.Collections.Generic;
using System.Text;

namespace learnin_test
{
    // имеем дом. В доме есть инженерные системы: отопление, водоснабжение, электроснабжение
    // каждая система имеет экземпляры оборудования
    // 

    abstract class EngineeringSystems
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public float Price { get; set; }

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

        public HeatingSystem(string name, string brand, float price, string resourceType) : base(name, brand, price)
        {
            ResourceType = resourceType;
        }

        public override void StartSystem()
        {
            Console.WriteLine($"{Name.Substring(0, 1).ToUpper() + Name.Substring(1).ToLower()} фирмы {Brand} запущен. Данное оборудовани стоило {Price} рублей. Для работы требуется {ResourceType}.");
        }

    }

    class WaterSupplySystem : EngineeringSystems
    {
        public string HotAndCold
        {
            get
            {
                if (HotAndCold == "горячая и холодная")
                {
                    HotAndCold = "горячей и холодной";
                    return HotAndCold; 
                }
                else
                {
                    return HotAndCold;
                }
            }
            set
            {
                
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
            Console.WriteLine($"Установлен и протестирован {Name} фирмы {Brand}. Место установки: {IntendedUse}. Предназначен для использования с {HotAndCold} водой. Стоимость оборудования составила {Price} рублей.");
        }

    }

    //class ElectricitySupplySystem : EngineeringSystems
    //{
    //    public string RougeOrFinishing { get; set; }

    //    public override void StartSystem()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}


    //class SewerageSystem : EngineeringSystems
    //{
    //    public int PipeDiameter { get; set; }
    //    public override void StartSystem()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}


}
