using Fitness_plus.BL.Controller;
using Fitness_plus.BL.Model;
using System;

namespace Fitness_plus.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi , honey , it's Fitness Plus!");

            Console.WriteLine("Enter user name please");
            var name = Console.ReadLine();

            var userController = new UserController(name);
            if (userController.IsNewUser)
            {
                Console.WriteLine("Enter your gender:");
                var gender = Console.ReadLine();
                var birthDate = ParseDateTime();
                var weight = ParseDouble("вес");
                var height = ParseDouble("рост");               

                userController.SetNewUserData(gender, birthDate, weight, height);
            }
            Console.WriteLine(userController.CurrentUser);
            Console.ReadLine();
        }

        private static DateTime ParseDateTime()
        {
            DateTime birthDate;
            while (true)
            {
                Console.WriteLine("Enter the day when you birth(dd.MM.yyyy)");
                if (DateTime.TryParse(Console.ReadLine(), out birthDate))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный формат даты рождения!");
                }
            }

            return birthDate;
        }

        private static double ParseDouble(string name)
        {
            while (true)
            {
                Console.WriteLine($"Enter {name} :");
                if (double.TryParse(Console.ReadLine(), out double value))
                {
                    return value;                    
                }
                else
                {
                    Console.WriteLine($"Неверный формат {name} !");
                }
            }
        }
    }
}
