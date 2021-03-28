using System;
using System.Collections.Generic;
using System.Text;

namespace learnin_test
{
    interface IParameter
    {
        float Efficiency { get; } //работоспособность
        void Damage(int damage);
        void Restore();
    }



    abstract class ElectricController<T> where T : IParameter
    {
        public T Parameter { get; protected set; }

    }

    class RobotEfficiency : IParameter
    {
        public float Efficiency => (_armor + _capacity) / 2;

        private int _armor;
        private int _capacity;
        private readonly Random _random = new Random();
        public RobotEfficiency()
        {
            Restore();
        }
        public void Restore()
        {
            _armor = 100;
            _capacity = 100;
        }

        public void Damage(int damage)
        {
            var damageType = _random.Next(0, 3);
            switch (damageType) 
            {
                case 0:
                    _armor -= damage;
                    break;
                case 1:
                    _capacity -= damage;
                    break;
                default:
                    _armor -= damage;
                    _capacity -= damage;
                    break;              
            }
        }
        public override string ToString()
        {
            return $"Armor: {_armor}, Capacity: {_capacity}";
        }
    }

    class IronEfficiency : IParameter
    {
        public float Efficiency => _heatingPercent;
        private int _heatingPercent;

        public IronEfficiency()
        {
            Restore();
        }
        public void Restore() 
        {
            _heatingPercent = 100;
        }

        public void Damage(int damage)
        {
            _heatingPercent -= damage;
        }
        public override string ToString()
        {
            return $"Heating: {_heatingPercent}%";
        }
    }

    class Robot : ElectricController<RobotEfficiency> 
    {
        public Robot()
        {
            Parameter = new RobotEfficiency();
        }

        public override string ToString()
        {
            return $"Robot [{Parameter}]";
        }
    }

    class Iron : ElectricController<IronEfficiency>
    {
        public Iron()
        {
            Parameter = new IronEfficiency();
        }
        public override string ToString()
        {
            return $"Iron [{Parameter}]";
        }
    }

    static class RepairMan 
    {
        public static void Repair<T>(ElectricController<T> part) where T : IParameter
        {
            if (part.Parameter.Efficiency < 100) 
            {
                part.Parameter.Restore();
                Console.WriteLine($"{part} restored");
                return;
            }
            Console.WriteLine($"{part} was OK");

        }
    }
}
