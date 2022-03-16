

namespace Dom_rabota 
{ 
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            Cat Cat = new Cat("Tomi", 8, "Bengal");
            Console.WriteLine($"Cat name is: {Cat.Name} \nCat age is: {Cat.Age} \nCat breed is: {Cat.Breed}");
        }
    }
}
