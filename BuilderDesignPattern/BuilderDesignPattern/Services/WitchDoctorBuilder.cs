using BuilderDesignPattern.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Services
{
    class WitchDoctorBuilder : ClassCharacterBuilder
    {
        public WitchDoctorBuilder()
        {
            classCharacter = new ClassCharacter("Witch Doctor");
        }
        public override void BuildAtributtes()
        {
            classCharacter["atributtes"] = "Intelect";
        }
        public override void BuildSpec()
        {
            classCharacter["spec"] = "Plague";
        }
        public override void BuildGender()
        {
            classCharacter["gender"] = "Male";
        }
        public override void BuildRace()
        {
            classCharacter["race"] = "Human";
        }
        public override void BuildFaction()
        {
            classCharacter["faction"] = "Horde";
        }
    }
}
