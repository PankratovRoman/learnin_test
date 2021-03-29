using System;
using System.Collections.Generic;
using System.Text;

namespace learnin_test
{
    interface IProgrammingTeaching 
    {
        void Teach();
    }

    interface IProgrammingLearning 
    {
        void Learn();
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

        public SerRomJenKap(string name, string profession)
        {
            Name = name;
            Profession = profession;
        }

        public abstract void Meeting();


    }

    class Roman : SerRomJenKap, IProgrammingLearning
    {
        public bool PossibilityToLearn;
        public Roman(string name, bool possibilityToLearn) : base (name)
        {
            PossibilityToLearn = possibilityToLearn;
        }

        public Roman(string name, string profession, bool possibilityToLearn) : base(name, "clown")
        {
            PossibilityToLearn = possibilityToLearn;
        }

        public void Learn()
        {
            throw new NotImplementedException();
        }

        public override void Meeting()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Name {Name} + Profession {Profession}  + Skill {Skill} + SkillLevel {SkillLevel} + PenisLength {PenisLength}";
        }
    }

    class Sergey : SerRomJenKap, IProgrammingTeaching
    {
        public bool PossibilityToTeach;
        public Sergey(string name, bool possibilityToTeach) : base(name)
        {
            PossibilityToTeach = possibilityToTeach;
        }

        public void Teach()
        {
            throw new NotImplementedException();
        }

        public override void Meeting()
        {
            throw new NotImplementedException();
        }
    }
}
