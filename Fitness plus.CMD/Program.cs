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

            Console.WriteLine("Enter your gender");
            var gender = Console.ReadLine();

            Console.WriteLine("Enter your Birth Date");
            var birthdate = DateTime.Parse(Console.ReadLine());//переписать

            Console.WriteLine("Enter your weight");
            var weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your height");
            var heigt = double.Parse(Console.ReadLine());

            var userController = new UserController(name, gender, birthdate, weight, heigt);
            userController.Save();
        }
    }
}
