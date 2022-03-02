using BuilderDesignPattern.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Services
{
    class DemonHunterBuilder : ClassCharacterBuilder
    {
        public DemonHunterBuilder()
        {
            classCharacter = new ClassCharacter("Demon hunter");
        }
        public override void BuildAtributtes()
        {
            classCharacter["atributtes"] = "Dextity";
        }
        public override void BuildSpec()
        {
            classCharacter["spec"] = "Assasin";
        }
        public override void BuildGender()
        {
            classCharacter["gender"] = "Female";
        }
        public override void BuildRace()
        {
            classCharacter["race"] = "Orc";
        }
        public override void BuildFaction()
        {
            classCharacter["faction"] = "Horde";
        }
    }
}
