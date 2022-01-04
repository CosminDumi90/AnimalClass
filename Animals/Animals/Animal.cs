using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animal:ISoundProduceable
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }



        public virtual void ProduceSound()
        {
            Console.WriteLine($"{this.GetType().Name}\n{this.name} {this.age} {this.gender}");
            Console.WriteLine("Default animal sound\n"); 
        
        }

       



    }
}
