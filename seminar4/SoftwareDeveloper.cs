using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar4
{
    class SoftwareDeveloper : Person, IProgrammingLanguages
    {
        public SoftwareDeveloper(string name, int age, string[] languages) :base(name, age)
        {
            Languages = languages;
        }

        public string[] Languages { get; set; }

        public bool Knows(string language)
        {
            return Languages.Contains(language);
        }

        public override string ToString()
        {
            return "Name: " + Name + ", Age: " + Age + " Languages: " + string.Join(", ", Languages);
        }
    }
}
