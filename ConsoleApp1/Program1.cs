// OOP

// using System;

// namespace ConsoleApp1
// {
//     class Person(string name, int age, string gender)
//     {
//         public string Name { get; set; } = name;
//         public int Age { get; set; } = age;
//         // public string gender = "Female";
//         public string Gender { get; set; } = gender;
//         public static string Talk()
//         {
//             return "What's up?";
//         }
//     }
// }

// inheritance
// using System;

// namespace ConsoleApp1
// {
//     class Vehicle
//     {
//         public string brand = "Ford";

//         public void Honk()
//         {
//             Console.WriteLine("tuut! tuut!");
//         }
//     }

//     class Car: Vehicle
//     {
//         public string model = "Mustang";
//     }
// }

//polymorphism
// using System;

// namespace ConsoleApp1
// {
//     class Animal
//     {
//         public virtual void AnimalSound()
//         {
//             Console.WriteLine("The animal makes a sound");
//         }
//     }

//     class Pig:Animal
//     {
//         public override void AnimalSound()
//         {
//             Console.WriteLine("The pig says: wee wee");
//         }
//     }

//     class Dog:Animal
//     {
//         public override void AnimalSound()
//         {
//             Console.WriteLine("The dog says: bow bow");
//         }
//     }
// }

//abstaraction
using System;

namespace ConsoleApp1
{
    abstract class Animal
    {
        public abstract void AnimalSound();
        public void Sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    class Lion : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The lion says: roar roar");
        }
    }
}