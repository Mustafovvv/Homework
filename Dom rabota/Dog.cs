


namespace Dom_rabota
{ 
    using System;
    public class Dog : Mammal
    {
        public Dog(string name, int age, string breed)
            :base (name, age, breed)
        {

        }

        public override string Eat()
        {
            return "Dog eat!!!";
        }

        public override string MakeSound()
        {
            return "Bark!";
        }
    }
}
