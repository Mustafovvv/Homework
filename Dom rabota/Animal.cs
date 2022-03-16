


namespace Dom_rabota
{
    using System;
    public abstract class Animal
    {
        private string name;
        private int age;

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Name!");
                }

                if (value.Length <= 3)
                {
                    throw new ArgumentException("Invalid Name!");
                }

                this.name = value;
            }

        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid Age!");
                }

                this.age = value;
            }
        }

        public abstract string MakeSound();
    }
}
