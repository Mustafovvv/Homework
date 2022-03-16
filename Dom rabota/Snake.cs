


namespace Dom_rabota
{ 
    using System;
    public class Snake : Reptile 
    {
        public Snake(string name, int age)
            :base (name, age)
        {

        }

        public override string MakeSound()
        {
            return "Ssss!";
        }

    }
}
