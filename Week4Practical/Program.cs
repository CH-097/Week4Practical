/*
 * Week 4 practical
 * using arrays and sorting
 */

using System.Collections.Concurrent;
using System.Drawing;
using Week4Practical;
class Program
{
    static void Main(string[] args)
    {
        /*  challenge 1: using arrays and forcing errors
        //declare and initialise a string array 'carManufacturers'
        string[] carManufacturers = { "Ford", "Toyota", "BMW", "Honda" };

        //foreach loop to print all 4 brands to verify they have been stored correctly.
        foreach (var brand in carManufacturers)
        {
            Console.WriteLine(brand);
        }


        //use Array.Sort() method, write second loop to print result
        Array.Sort(carManufacturers);
        foreach (var brand in carManufacturers)
        {
            Console.WriteLine(brand);
        }


        //chellenge 5: Exception Handling
        //standard loop to iterate through the array,

        try
        {
            for (int carIndex = 0; carIndex <= carManufacturers.Length; carIndex++)
            {
                Console.WriteLine(carManufacturers[carIndex]);
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: Attempted to access an array index that does not exist");
        }
        finally
        {
            Console.WriteLine("Array processing complete");
        }

        */



        /*  challenge 2: Dynamic
        //create empty list called months
        List<string> months = new List<string>();

        // use .Add() method to insert all 12 months
        months.Add("January");
        months.Add("February");
        months.Add("March");
        months.Add("April");
        months.Add("May");
        months.Add("June");
        months.Add("July");
        months.Add("August");
        months.Add("September");
        months.Add("October");
        months.Add("November");
        months.Add("December");

        //print the .Count property to verify it holds 12 items
        Console.WriteLine(months.Count);

        // use indexOf() method to find index of december
        Console.WriteLine(months.IndexOf("December"));

        //convert dynamic collection (list) back to a fixed one (array) using .ToArray() method
        string[] array = months.ToArray();
        

        //output the array to screen
        foreach (string month in array)
        {
            Console.WriteLine(month);
        }
        */




        /* chalenge 3: Dictionaries and key-value pairs
        // create Dictionary<string, int> called inventory
        Dictionary<string, int> inventory = new Dictionary<string, int>();

        //add 3 specific items to inventory with .Add()
        // item name, quantity
        inventory.Add("Health Potion", 5);
        inventory.Add("Mana Potion", 2);
        inventory.Add("Gold Coin", 100);

        //overwrite, change quantity of health potions from 5 to 20
        inventory["Health Potion"] = 20;
        Console.WriteLine(inventory["Health Potion"]);


        try
        {
            //attempt to access a key that doesnt exist
            Console.WriteLine(inventory["Iron Sword"]);    
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: Attempted to access an array index that\r\ndoes not exist");
        }
        finally
        {
            Console.WriteLine("Array processing complete");
        }

        */


        //challenge 5: Storing custom data types and reference types
        //after creating Student class, instantiate (create object) student1
        Student student1 = new Student();
        student1.Id = 1;
        student1.Name = "Alice Smith";
        student1.Age = 20;

        //create List<Student> 
        List<Student> students = new List<Student>();
        //use the .Add() method to insert student1 into the collection

        //To observe how reference types behave in memory, create a second variable
        //and assign the first to it: Student student2 = student1;
        Student student2 = new Student();
        student1.Id = 2;
        student1.Name = "John Doe";
        student1.Age = 99;

        student2 = student1;

        student1.Display();




    }
}

