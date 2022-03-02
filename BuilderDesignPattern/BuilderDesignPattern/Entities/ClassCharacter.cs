using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Entities
{
    class ClassCharacter
    {
        private string _className;
        private Dictionary<string, string> _features =
            new Dictionary<string, string>();

        public ClassCharacter(string className)
        {
            this._className = className;
        }

        public string this[string key]
        {
            get { return _features[key]; }
            set { _features[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Class Type: {0}", _className);
            Console.WriteLine(" Attributes : {0}", _features["atributtes"]);
            Console.WriteLine(" Specialization : {0}", _features["spec"]);
            Console.WriteLine(" Gender: {0}", _features["gender"]);
            Console.WriteLine(" Race : {0}", _features["race"]);
            Console.WriteLine(" Faction : {0}", _features["faction"]);
        }
    }
}
