using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        
        int n = int.Parse(Console.ReadLine());

        Dictionary<string, int> phoneBook = new Dictionary <string, int>();

        for(int i = 0; i < n; i++)
        {
            var entry = Console.ReadLine().Split(' ');
            var name = entry[0];
            int phoneNumber = int.Parse(entry[1]);
            phoneBook.Add(name, phoneNumber);
        }

        for (int j = 0; j < n; j++)
        {
            var phoneBookEntry = Console.ReadLine();

            if (phoneBook.ContainsKey(phoneBookEntry))
            {
               int phone = phoneBook[phoneBookEntry];
               Console.WriteLine($"{phoneBookEntry}={phone}");
            }
            else
            {
                Console.WriteLine("Not found");
            }

        }
    }
}

