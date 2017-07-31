using System;
using System.Collections.Generic;

namespace democode
{
    class Program
    {
        static void Main(string[] args)
        {
            // Three Basic Arrays
            // Create an array to hold integer values 0 through 9
            int[] thisArray = new int[10];
            for (int i = 0; i < 10; ++i){
                thisArray[i] = i;
                // Console.WriteLine(i);
            }

            // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] nameArray = new string[4];
            nameArray[0] = "Tim";
            nameArray[1] = "Martin";
            nameArray[2] = "Nikki";
            nameArray[3] = "Sara";
            // foreach (string name in nameArray){
            //     Console.WriteLine(name);
            // }

            // Create an array of length 10 that alternates between true and false values, starting with true
            bool[] boolArray = new bool[10];
            for (int i = 0; i < 10; i++){
                if (i%2==0){
                    boolArray[i] = true;
                }
                else{
                    boolArray[i] = false;
                }
            }
            // foreach (bool factoid in boolArray){
            //     Console.WriteLine(factoid);
            // }

            // Multiplication Table
            // With the values 1-10, use code to generate a multiplication table like the one below.
            // Use a multidimensional array to store all values
            short[,] multiplicationTable = new short[10,10];
            for (int i = 0; i < 10; i++){
                for (int j = 0; j < 10; j++){
                    multiplicationTable[i,j] = (Int16)((i + 1) * (j + 1));
                    // Console.WriteLine(multiplicationTable[i,j]);
                }
            }
            
            // List of Flavors
            // Create a list of Ice Cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            List<string> flavors = new List<string>();
            flavors.Add("Chocolate");
            flavors.Add("Fireside S'Mores");
            flavors.Add("Einstein Ice");
            flavors.Add("Vanilla");
            flavors.Add("Elvis Has Left the Building");
            // Output the length of this list after building it
            Console.WriteLine(flavors.Count);
            // Output the third flavor in the list, then remove this value.
            Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);
            // Output the new length of the list (Note it should just be one less~)
            Console.WriteLine(flavors.Count);
            
            // User Info Dictionary
            // Create a Dictionary that will store both string keys as well as string values
            Dictionary<string,string> favorites = new Dictionary<string,string>();
            // For each name in the array of names you made previously, add it as a new key in this dictionary with value null
            foreach (string name in nameArray){
                favorites.Add(name, null);
            }
            // For each name key, select a random flavor from the flavor list above and store it as the value
            Random rand = new Random();
            List<string> keys = new List<string>(favorites.Keys);
            for (int i = 0; i < keys.Count; i++){
                favorites[keys[i]] = flavors[rand.Next(0,4)];
            }
            // Loop through the Dictionary and print out each user's name and their associated ice cream flavor.            
            foreach (var entry in favorites){
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
        }
    }
}
