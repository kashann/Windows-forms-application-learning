using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Person : IComparable<Person>

    {
	    private int _age;

	    public int GetAge()
	    {
		    return _age;
	    }

	    public void SetAge(int value)
	    {
		    _age = value;
	    }

	    public string Name { get; set; }

	    public Person(int age, string name)
	    {
		    _age = age;
		    Name = name;
	    }

        public int CompareTo(Person other)
        {
            /*if (_age < other._age)
                return -1;
            else if (_age > other._age)
                return 1;
            else return 0;*/

            var ageComparison = _age.CompareTo(other._age);
            if (ageComparison != 0)
                return ageComparison;
            else
                return Name.CompareTo(other.Name);
        }

        public override string ToString()
	    {
		    return string.Format("Name: {0}, Age: {1}", Name, _age);
	    }
	    
    }

    class PersonNameAsc : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }

    class PersonNameDesc : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return -x.Name.CompareTo(y.Name);
        }
    }
}
