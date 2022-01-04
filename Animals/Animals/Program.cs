using System;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat("Tom", 12, "female");
            Animal dog = new Dog("Fido", 10, "male");
            Animal kitten = new Kitten("Timmy", 10);
            Animal frog = new Frog("Kermit", 5, "male");
            Animal tomcat = new Tomcat("Butch", 3);

            dog.ProduceSound();
            cat.ProduceSound();
            frog.ProduceSound();
            tomcat.ProduceSound();
            kitten.ProduceSound();
        }
    }
}
