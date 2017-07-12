using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, string> snackMachine = new Dictionary<string, string>()
            //{
            //    { "A1", "Twix" }, // { "key", "value" } (key value pair)
            //    { "A2", "Twizzlers" },
            //    { "A3", "Reeses" },
            //    { "A4", "Sourpatch Kids" }
            //};
            //foreach (KeyValuePair<string, string> item in snackMachine)
            //{
            //    Console.WriteLine(item); // prints out all key value pairs
            //}

            //foreach (var item in snackMachine) // not best practice to use this because you don't know what data type you're using
            //{
            //    Console.WriteLine(item);
            //}

            //Dictionary<int, string> drinkMachine = new Dictionary<int, string>();
            //drinkMachine.Add(10, "Ginger Ale"); // using add method
            //drinkMachine.Add(11, "Bottled Water");
            //drinkMachine.Add(12, "Orange Juice");
            //drinkMachine.Add(13, "Fruit Punch");
            //drinkMachine.Add(14, "Mountain Dew Code Red");

            ////Console.WriteLine(drinkMachine.Count); // using count method to give number of entries

            //foreach (KeyValuePair<int,string> drink in drinkMachine)
            //{
            //    Console.WriteLine(drink.Key); // drink.Key will return all the keys
            //    Console.WriteLine(drink.Value); //drink.Value will return all the values
            //}

            // Create a dictionary for a theater coat check with 10 elements
            // key will be a number
            // value wil be coat style
            // print all elements to the console

            //Dictionary<int, string> coatCheck = new Dictionary<int, string>()
            //{
            //    {1, "black suit jacket" },
            //    {2, "red blazer" },
            //    {3, "blue rain coat" },
            //    {4, "floral spring jacket" },
            //    {5, "winter coat" },
            //    {6, "blue blazer" },
            //    {7, "grey suit jacket" },
            //    {8, "North Face" },
            //    {9, "Trench" },
            //    {10, "Columbia" }
            //};

            //foreach (KeyValuePair<int, string> coatOwnership in coatCheck)
            //{
            //    Console.WriteLine(coatOwnership.Key);
            //    Console.WriteLine(coatOwnership.Value);
            //}

            // Car valet with 10 cars.
            // Key will be a customer's last name
            // Value will be the car make.
            // Print all elements to the console.

            //Dictionary<string, string> carValet = new Dictionary<string, string>()
            //{
            //    {"Smith", "Buick Regal" },
            //    {"Meyer", "Mercedes-Benz" },
            //    {"DeLuca", "Jeep Wrangle" },
            //    {"McDonnel", "Chevy" },
            //    {"Jones", "Kia" },
            //    {"Ryan", "Limo" },
            //    {"Jackson", "Toyota Camry" },
            //    {"Johnson", "Ford Escape" },
            //    {"Roberts", "Toyota Corolla" },
            //    {"Robinson", "Convertible" }
            //};
            //foreach (KeyValuePair<string,string> carOwnership in carValet)
            //{
            //    Console.WriteLine(carOwnership.Key);
            //    Console.WriteLine(carOwnership.Value);
            //}

            // Create a dictionary of 10 zoo animals.
            // Key will be the animal type
            // Value will be the number of animals

            Dictionary<string, int> zooAnimals = new Dictionary<string, int>();

            Console.WriteLine("Enter an animal.");
            string userAnimalOne = Console.ReadLine();

            Console.WriteLine("Enter an animal.");
            string userAnimalTwo = Console.ReadLine();

            Console.WriteLine("Enter an animal.");
            string userAnimalThree = Console.ReadLine();

            Console.WriteLine("Enter an animal.");
            string userAnimalFour = Console.ReadLine();

            Console.WriteLine("Enter an animal.");
            string userAnimalFive = Console.ReadLine();

            Console.WriteLine("Enter an animal.");
            string userAnimalSix = Console.ReadLine();

            Console.WriteLine("Enter an animal.");
            string userAnimalSeven = Console.ReadLine();

            Console.WriteLine("Enter an animal.");
            string userAnimalEight = Console.ReadLine();

            Console.WriteLine("Enter an animal.");
            string userAnimalNine = Console.ReadLine();

            Console.WriteLine("Enter an animal.");
            string userAnimalTen = Console.ReadLine();

            zooAnimals.Add(userAnimalOne, 1);
            zooAnimals.Add(userAnimalTwo, 2);
            zooAnimals.Add(userAnimalThree, 3);
            zooAnimals.Add(userAnimalFour, 4);
            zooAnimals.Add(userAnimalFive, 5);
            zooAnimals.Add(userAnimalSix, 6);
            zooAnimals.Add(userAnimalSeven, 7);
            zooAnimals.Add(userAnimalEight, 8);
            zooAnimals.Add(userAnimalNine, 9);
            zooAnimals.Add(userAnimalTen, 10);

            // Print the animal with the highest quantity to the console
            // Remove the zoo animal with the lowest quantity using the Remove method.
            
            //Console.WriteLine(zooAnimals.Values.Max());
            //Console.WriteLine(zooAnimals.Values.Min());

            //Console.WriteLine(zooAnimals.Key(zooAnimals.Values.Max()));

           //oreach (KeyValuePair<string,int> animal in zooAnimals)
            {
                Console.WriteLine(            }

            //{
            //    Console.WriteLine(carOwnership.Key);
            //    Console.WriteLine(carOwnership.Value);
            //}

            //zooAnimals.Remove();

        }
    }
}
