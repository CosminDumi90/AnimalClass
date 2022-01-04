using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Tomcat:Cat
    {
        private string name;
        private int age;
        private string gender;

        public Tomcat(string name, int age, string gender = "male") : base(name, age, gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public override void ProduceSound()
        {
            Console.WriteLine($"{this.GetType().Name}\n{this.name} {this.age} {this.gender}");
            Console.WriteLine("MEOW\n");
        }
    }
}
