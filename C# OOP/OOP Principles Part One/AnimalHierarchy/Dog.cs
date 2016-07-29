﻿namespace AnimalHierarchy
{
    using System;

    public class Dog : Animal
    {
        public Dog(string name, int age, string gender)
            : base(name, age, gender)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Bau-bau");
        }
    }
}
