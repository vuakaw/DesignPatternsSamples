using BuilderDesignPattern.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Services
{
    abstract class ClassCharacterBuilder
    {
        protected ClassCharacter classCharacter;

        public ClassCharacter ClassCharacter
        {
            get { return classCharacter; }
        }

        public abstract void BuildAtributtes();
        public abstract void BuildSpec();
        public abstract void BuildGender();
        public abstract void BuildRace();
        public abstract void BuildFaction();
    }
}
