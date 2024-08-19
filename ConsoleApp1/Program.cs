// using System;
// using System.Net.NetworkInformation;

// //this is a comment
// namespace ConsoleApp1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello CSharp");

//             //declaring variables
//             int x, y, z;
//             x = y = z = 50;
//             Console.WriteLine(x + y + z);
//             int j = 10, k = 20, l = 30;
//             Console.WriteLine(j + k + l);
//             const double Pi = 3.142;
//             Console.WriteLine(Pi);

//             //data types
//             string name = "Syncfusion";
//             Console.WriteLine(name[0]);
//             string vikings = "We're \"Vikings\" from the North";
//             Console.WriteLine(vikings);
//             int age = 23;
//             Console.WriteLine(age);
//             double revenue = 10.2;
//             Console.WriteLine(revenue);
//             char init = 'S';
//             Console.WriteLine(init);
//             bool old = true;
//             Console.WriteLine(old);

//             //type casting
//             string num1 = "1";
//             Console.WriteLine(Convert.ToInt32(num1));

//             Console.WriteLine("Enter you name ");
//             string userInput = Console.ReadLine().Trim();
//             Console.WriteLine($"Your name is {userInput}");

//             //operators/Maths
//             int number1 = 2;
//             int number2 = 3;
//             Console.WriteLine(number1 + number2);
//             Console.WriteLine(number1 * number2);
//             Console.WriteLine(number1 - number2);
//             Console.WriteLine(number2 / number1);
//             number1 += 1;
//             number1++;
//             Console.WriteLine(Math.Max(number1, number2));
//             Console.WriteLine(Math.Sqrt(64));
//             Console.WriteLine(number1 < number2);
//             Console.WriteLine(number1 == number2);
//             Console.WriteLine(number1 != number2);

//             Console.WriteLine(number1 > number2 && 3 > 2);
//             Console.WriteLine(number1 > number2 || 4 > 3);
//             Console.WriteLine(!(number1 > number2));

//             //booleans
//             bool isMarried = false;
//             bool isYouth = true;
//             Console.WriteLine(isMarried);
//             Console.WriteLine(isYouth);
//             int myAge = 25;
//             int votingAge = 18;
//             if (myAge >= votingAge)
//             {
//                 Console.WriteLine("Old enough to vote");
//             }
//             else
//             {
//                 Console.WriteLine("Not old enough to vote");
//             }
//             string result = (myAge > votingAge) ? "Old enough to vote" : "Not old enough to vote";
//             Console.WriteLine(result);

//             int days = 5;
//             switch (days)
//             {
//                 case 1:
//                     Console.WriteLine("Monday");
//                     break;
//                 case 2:
//                     Console.WriteLine("Tuesday");
//                     break;
//                 case 3:
//                     Console.WriteLine("Wednesday");
//                     break;
//                 case 4:
//                     Console.WriteLine("Thursday");
//                     break;
//                 case 5:
//                     Console.WriteLine("Friday");
//                     break;
//                 case 6:
//                     Console.WriteLine("Saturday");
//                     break;
//                 case 7:
//                     Console.WriteLine("Sunday");
//                     break;
//                 default:
//                     Console.WriteLine("what day?");
//                     break;
//             }
//             int i = 0;
//             while (i < 5)
//             {
//                 Console.WriteLine("Coding is fun");
//                 i++;
//             }

//             int m = 0;
//             do
//             {
//                 Console.WriteLine("CSharp is cool");
//                 m++;
//             } while (m < 5);

//             for (int s = 0; s < 5; s++)
//             {
//                 Console.WriteLine("I am a software engineer");
//             }

//             string[] myCars = { "Mercedes", "volvo", "Audi", "BMW", "Mazda" };
//             foreach (string car in myCars)
//             {
//                 Console.WriteLine(car);
//             }

//             int[,] my2d = { { 1, 2, 3 }, { 4, 5, 6 } };
//             foreach (int num in my2d)
//             {
//                 Console.WriteLine(num);
//             }

//             int[] myNumbers = { 2, 1, 4, 7, 8, 9, 3, 5 };
//             Array.Sort(myNumbers);
//             foreach (int num in myNumbers)
//             {
//                 Console.WriteLine(num);
//             }
//         }

//     }
// }

// methods, parameters, and arguments
// using System;

// namespace ConsoleApp1
// {
//     class Program
//     {
//         static void Username(string firstName, string lastName)
//         {
//             Console.WriteLine($"Name: {firstName} {lastName}");
//         }

//         static void NameAge(string name, int age)
//         {
//             Console.WriteLine($"{name} is {age} years old.");
//         }
//         static void Main(string[] args)
//         {
//             Username("Jon", "Doe");
//             NameAge("Jon", 40);
//         }
//     }
// }


// default parameters
// using System;

// namespace ConsoleApp1
// {
//     class Program
//     {
//         static void Country(string name = "Kenya")
//         {
//             Console.WriteLine(name);
//         }
//         static void Main(string[] args)
//         {
//             Country("Germany");
//             Country("Nigeria");
//             Country();
//             Country("India");
//             Country("USA");
//         }
//     }
// }


//return values
// using System;

// namespace ConsoleApp1
// {
//     class Program
//     {
//         static int AddNums(int x, int y)
//         {
//             return x + y;
//         }
//         static void Main(string[] args)
//         {
//             int z = AddNums(4, 6);
//             Console.WriteLine(z);
//         }
//     }
// }


//named arguments and method overloading 
using System;

// namespace ConsoleApp1
// {
//     class Program
//     {
//         //named arguments
//         static string MyMethod(string child1, string child2, string child3)
//         {
//             return $"The youngest child is {child3}";
//         }

//         // method overloading
//         static int PlusMethod(int x, int y)
//         {
//             return x + y;
//         }

//         static double PlusMethod(double x, double y)
//         {
//             return x + y;
//         }
//         static void Main(string[] args)
//         {
//             Console.WriteLine(MyMethod(child3: "John", child1: "Liam", child2: "Richard"));
//             Console.WriteLine($"Int: {PlusMethod(3, 4)}");
//             Console.WriteLine($"Double: {PlusMethod(3.5, 4.3)}");
//         }
//     }
// }

// OOP
// using System;

// namespace ConsoleApp1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Person person1 = new("Jon Doe", 30, "Male");
//             Person person2 = new("Jane Doe", 24, "Female");
//             Console.WriteLine(Person.Talk());
//             Console.WriteLine($"{person1.Name} is {person1.Age} years old");
//             Console.WriteLine(person1.Gender);
//         }
//     }
// }

// inheritance
// using System;

// namespace ConsoleApp1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Car myCar = new();
//             myCar.Honk();
//             Console.WriteLine($"My {myCar.brand} {myCar.model}");
//         }
//     }
// }

//polymorphism
// using System;

// namespace ConsoleApp1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Animal myAnimal = new Animal();
//             Animal myPig = new Pig();
//             Animal myDog = new Dog();

//             myAnimal.AnimalSound();
//             myDog.AnimalSound();
//             myPig.AnimalSound();
//         }
//     }
// }

//abstarction
// using System;

// namespace ConsoleApp1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Lion myLion = new Lion();
//             myLion.AnimalSound();
//             myLion.Sleep();
//         }
//     }
// }


//interfaces
// using System;

// namespace ConsoleApp1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Goat myGoat = new Goat();
//             myGoat.AnimalSound();
//         }
//     }
// }


//multiple interfaces
// using System;

// namespace ConsoleApp1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             DemoClass myDemoClass = new DemoClass();
//             myDemoClass.MyMethod1();
//             myDemoClass.MyMethod2();
//         }
//     }
// }


//enums
using System;

namespace ConsoleApp1
{
    class Program
    {
        // enum Level
        // {
        //     Low, Medium, High
        // }

        enum Months
        {
            January, February, March, April, May, June, July, August, September, October, November, December
        }

        static void Main(string[] args)
        {
            // Level myEnum = Level.Medium;
            // Console.WriteLine($"This is a {myEnum} level question");
            Months myBirthMonth = Months.October;
            int birthMonth = (int)myBirthMonth + 1;
            Console.WriteLine($"He was born in the {birthMonth}th month of the year.");

            switch (myBirthMonth)
            {
                case Months.January:
                    {
                        Console.WriteLine("January");
                        break;
                    }
                case Months.February:
                    {
                        Console.WriteLine("February");
                        break;
                    }
                case Months.March:
                    {
                        Console.WriteLine("March");
                        break;
                    }
                case Months.April:
                    {
                        Console.WriteLine("April");
                        break;
                    }
                case Months.May:
                    {
                        Console.WriteLine("May");
                        break;
                    }
                case Months.June:
                    {
                        Console.WriteLine("June");
                        break;
                    }
                case Months.July:
                    {
                        Console.WriteLine("July");
                        break;
                    }
                case Months.August:
                    {
                        Console.WriteLine("August");
                        break;
                    }
                case Months.September:
                    {
                        Console.WriteLine("September");
                        break;
                    }
                case Months.October:
                    {
                        Console.WriteLine("October");
                        break;
                    }
                case Months.November:
                    {
                        Console.WriteLine("November");
                        break;
                    }
                case Months.December:
                    {
                        Console.WriteLine("December");
                        break;
                    }
            }
        }
    }
}