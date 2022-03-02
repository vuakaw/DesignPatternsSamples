using BuilderDesignPattern.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Services
{
    class PaladinBuilder : ClassCharacterBuilder
    {
        public PaladinBuilder()
        {
            classCharacter = new ClassCharacter("Paladin");
        }
        public override void BuildAtributtes()
        {
            classCharacter["atributtes"] = "Strength";
        }
        public override void BuildSpec()
        {
            classCharacter["spec"] = "Protection";
        }
        public override void BuildGender()
        {
            classCharacter["gender"] = "Male";
        }
        public override void BuildRace()
        {
            classCharacter["race"] = "Elf";
        }
        public override void BuildFaction()
        {
            classCharacter["faction"] = "Alliance";
        }
    }
}
