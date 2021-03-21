using System;
using System.Collections.Generic;
using System.Text;

namespace learnin_test
{
    abstract class Animal
    {
        //абстрактный класс - экземпляр не создается, но создается общий функционал.
        //abstract - ключевое слово, указывает, что класс абстрактный. Если попытаемся создать экземпляр, то компилятор ругнется.
        private string _name; //с этим мы ничего не делали, только в образовательных целях
        public string Name
        {
            get
            {
                return (_name.Substring(0, 1).ToUpper() + _name.Substring(1).ToLower());
            }
            set
            {
                _name = value;
            }
        } //value - ключевое слово. Означает переданное значение.

        protected readonly int MaxAge; //поля ридонли можно только вытаскивать и всегда необходимо определятиь в конструкторе



        //
        public abstract void Move(); //абстрактный метод. Тело метода не пишется. Всем наследникам говорит, что етсь этот метод, но тело определяется на нижних уровнях.

        protected Animal(string name, int maxAge)
        {
            Name = name;
            MaxAge = maxAge;
        }



    }
    class Parrot : Animal
    {
        public string Color;

        public Parrot(string name, string color) : base(name, 12)
        {
            Color = color;
        }

        public override void Move()
        {
            Console.WriteLine("{0} летает!", Name);
        }
        public override string ToString() //ToString есть у каждого класса и вызывается скрыто. Выодит информацию об экземпляре классе.
                                          //В случае переопределения, возвращает заданное значение.
        {
            return $"Я - {Color} попугай и живу до {MaxAge} лет";
        }


    }
    class Dog : Animal
    {
        public string Breed;

        public Dog(string name, string breed) : base(name, 15)
        {
            Breed = breed;
        }
        public override void Move()
        {
            Console.WriteLine("{0} бегает!", Name);
        }

    }
}

// задание:
// сабстринг у стринга. Свойство Name должно возвращать поле name, но исправленное так, чтобы первая буква была большая, а остальные маленькие. Делать в get.