using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Клас_и_Обект
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            
        }
    }
    class Person 
    {
        public string Name { get; set; }
        public string Name2 { get; set; }
        
        public int Age { get; set; }

        public Person() { }
        public override string ToString()
        {
            return($"I'm {Name} {Name2} and I'm {Age} old.");
        }
        public Person(string name1, string name2, int age)
        {
            this.Name = name1;
            this.Name2 = name2;
            this.Age = age;
        }
        public string GetFullname()
        {
            return ($"Full name - {Name} {Name2}");
        }
    }
}
