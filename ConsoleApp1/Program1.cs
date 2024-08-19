using System;

namespace ConsoleApp1
{
    class Person(string name, int age, string gender)
    {
        public string Name { get; set; } = name;
        public int Age { get; set; } = age;
        // public string gender = "Female";
        public string Gender { get; set; } = gender;
        public static string Talk()
        {
            return "What's up?";
        }
    }
}