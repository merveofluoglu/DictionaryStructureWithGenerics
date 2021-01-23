using System;

/*
 This program is a dictionary program that 
 defines the dictionary structure and includes simple methods

 Program takes key and value inputs from the user
 and adds them into the dictionary that i made and prints it 
 if the method is called.
 */

namespace DictionaryStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dict1 = new MyDictionary<int, string>();

            Console.WriteLine("Please enter you key and value respesctively: ");
            Console.WriteLine("Press '0' to exit.");

            while (true)
            {
                int key;
                string value;
                key = Convert.ToInt32(Console.ReadLine());
                if (key == 0)
                {
                    break;
                }
                value = Console.ReadLine();
                dict1.Add(key, value);
            }

            dict1.Print();
        }
    }
}
