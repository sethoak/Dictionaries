using System;
using System.Collections.Generic;

namespace DictionaryIntro
{
    class Program
    {
        static void Main(string[] args)
        //you have to specify the type of the key (ex string) in the <>. The second thing is the type of the value (ex string, int)
        //we named a variable cohortCount, it is of type Dictionary whose keys are strings and values are ints.
        //Right sign of equal, means it is to a a new empty dictionary
        {
            Dictionary<string, int> cohortCount = new Dictionary<string, int>();

            cohortCount.Add("Cohort 34", 20);
            cohortCount.Add("Cohort 35", 14);
            cohortCount.Add("Cohort 36", 28);
            cohortCount.Add("Cohort 37", 28);

            //iterate over the key value pairs. You specify the type and value... ex. string & int.
            foreach (KeyValuePair<string, int> item in collection)
            {
                Console.WriteLine($"{item.Key} has {item.Value} students.")
            }
            //Another way to declare a dictionary. Holding product names and prices
            Dictionary<string, double> products = new Dictionary<string, double>()
            {
                {"Deodorant", 4.50},
                {"Shampoo", 8.50},
                {"Hair Brush", 8.00},
                {"Tooth Brush", 2.50},
            };

            foreach (KeyValuePair<string, double> product in products)
            {
                Console.WriteLine($"{product.Key} costs ${product.Value}");
            }

        }
    }
}
