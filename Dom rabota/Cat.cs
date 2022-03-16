


namespace Dom_rabota
{
    using System;
    public class Cat : Mammal
    {
        public Cat(string name, int age, string breed)
            :base (name, age, breed)
        {

        }

        public override string MakeSound()
        {
            return "Meowwww!";
        }

        public override string Eat()
        {
            return "Meow, meow eattt.";
        }
    }
}
