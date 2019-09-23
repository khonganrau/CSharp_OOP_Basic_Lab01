using System;
using System.Collections.Generic;

namespace Lab_1_Advanced_Programming_Lab_1_doc_04_part_I
{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("eating...");
        }
    }
    class Dog : Animal
    {
        public new void Eat()
        {
            base.Eat();

        }
        public void Bark()
        {
            Console.WriteLine("barking...");
        }
    }
    class Puppy : Dog
    {
        public new void Eat()
        {
            base.Eat();

        }
        public new void Bark()
        {
            base.Bark();
        }
        public void Weep()
        {
            Console.WriteLine("Weeping...");
        }
    }
    class Cat : Animal
    {
        public new void Eat()
        {
            base.Eat();
        }
        public void Meow()
        {
            Console.WriteLine("Meowing...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Part I, 1. Single Inheritance \n");
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            Console.Write("Part I, 2. Multiple Inheritance \n");
            Puppy puppy = new Puppy();
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();

            Console.Write("Part I, 3. Hierarchical Inheritance \n");
            dog.Eat();
            dog.Bark();
            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();

            Console.ReadKey();
        }
    }
}
