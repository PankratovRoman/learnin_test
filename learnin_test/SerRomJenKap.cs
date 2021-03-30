using System;
using System.Collections.Generic;
using System.Text;

namespace learnin_test
{
    interface ITeach
    {
        bool ICanNow { get; }

    }

    abstract class SerRomJenKap
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public string Skill { get; set; }
        public int SkillLevel { get; set; }
        public float PenisLength { get; set; }
        protected SerRomJenKap(string name)
        {
            Name = name;
        }
        public SerRomJenKap(string name, string skill, int skillLevel, float penisLenght, string profession)
        {
            Name = name;
            Profession = profession;
            SkillLevel = skillLevel;
            PenisLength = penisLenght;
            Skill = skill;
        }

    }

    class Sergey : SerRomJenKap
    {
        bool WorkNow { get; }
        public Sergey(string name, bool workNow) : base(name, ".NET dev", 100, 20f, "developer/teacher")
        {
            WorkNow = workNow;
        }

       

        public void Teach(ITeach student)
        {
            if (!student.ICanNow && !WorkNow)
            {
                Console.WriteLine("Noone cant");
                return;
            }
            if (!student.ICanNow || WorkNow)
            {
                Console.WriteLine("Someone cant");
                return;
            }
            


        }

        public override string ToString()
        {
            return $"Name {Name}, Work now is {WorkNow}.";
        }

    }

    class Roman : SerRomJenKap, ITeach
    {
        //public bool PossibilityToLearn;
        public Roman(string name) : base(name, "crying like little girl", 0, 5f, "student")
        {

        }

        public bool ICanNow => true;

        public override string ToString()
        {
            return $"Name: {Name} + Profession: {Profession}  + Skill: {Skill} + SkillLevel: {SkillLevel} + PenisLength: {PenisLength}";
        }
    }


}
