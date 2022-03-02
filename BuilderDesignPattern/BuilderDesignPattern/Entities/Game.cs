using BuilderDesignPattern.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Entities
{
     class Game
    {
        public void Construct(ClassCharacterBuilder classCharacterBuilder)
        {
            classCharacterBuilder.BuildAtributtes();
            classCharacterBuilder.BuildSpec();
            classCharacterBuilder.BuildGender();
            classCharacterBuilder.BuildRace();
            classCharacterBuilder.BuildFaction();
        }
    }
}
