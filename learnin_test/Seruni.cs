using System;
using System.Collections.Generic;
using System.Text;

namespace learnin_test
{
    class Pacani
    {
        protected string Name; // публичное поле - с большой буквы
        protected string LevelOfSmell;
        public Pacani(string name) : this(name, "Нормально все!")
        {

        }
        protected Pacani(string name, string levelOfSmell)
        {
            Name = name;
            LevelOfSmell = levelOfSmell;
        }
        public virtual void ShoditVTubzik()
        {
            Console.WriteLine("{0} пошел покакать! {1}", Name, LevelOfSmell);
        }
    }

    class Seruni : Pacani
    {
        public Seruni(string name) : base(name, "Воняет и грязно!")
        {

        }
        public override void ShoditVTubzik()
        {
            Console.WriteLine("{0} - ебучий серун! Опять засрал весь унитаз! {1}", Name, LevelOfSmell);
        }
    }
}
