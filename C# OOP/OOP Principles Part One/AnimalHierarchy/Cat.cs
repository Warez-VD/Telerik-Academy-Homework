﻿namespace AnimalHierarchy
{
    using System;

    public class Cat : Animal
    {
        public Cat(string name, int age, string gender)
            : base(name, age, gender)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
