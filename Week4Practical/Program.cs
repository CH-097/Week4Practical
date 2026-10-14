/*
 * Week 4 practical
 * using arrays and sorting
 */

class Program
{
    static void Main(string[] args)
    {
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

        //standard loop to iterate through the array,
        for (int carIndex = 0; carIndex < carManufacturers.Length; carIndex++)
        {
            Console.WriteLine(carManufacturers[carIndex]);
        }

     
    }
}

