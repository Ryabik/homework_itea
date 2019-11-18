using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _1_LessonCollections.Collections
{
    public class HashTableExample
    {
        public static void MyHashTable()
        {
            Hashtable myHashTable = new Hashtable();

            myHashTable.Add("001", ".Net");
            myHashTable.Add("002", "C#");
            myHashTable.Add("003", "ASP.Net");
            myHashTable.Add("love", "JAVA");

            // Запомнить! только тип DictionaryEntry для перебора в foreach!

            Console.WriteLine("1st variant ");
            foreach (DictionaryEntry item in myHashTable)
            {
                Console.WriteLine($"Key {item.Key} : value - {item.Value} ");
            }
            // альтернатива - ICollection keys = myHashTable.Keys;
            Console.WriteLine("\n 2nd variant ");
            ICollection keys = myHashTable.Keys;
            //ICollection values = myHashTable.Values;
            foreach(string text in keys)
            {
                Console.WriteLine($"The key {text} has the value: {myHashTable[text]}");
            }


        }
    }
}
