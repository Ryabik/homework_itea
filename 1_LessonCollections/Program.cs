using _1_LessonCollections.Collections;
using _1_LessonCollections.MyDictionary;
using System;

namespace _1_LessonCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n-------ArrayList Example-------");
            ArrayListExample.MyArrayList();

            Console.WriteLine("\n-------HashTable Example-------");
            HashTableExample.MyHashTable();

            Console.WriteLine("\n-------Queue Example-------");
            QueueExample.MyQueue();


            Console.WriteLine("\n-------MY Dictionary Example-------");
            DictionaryExemple.MyDictionary();

            Console.WriteLine("\n-------Linked List<T>-------");
            LinkedListGeneric.Manipulations();
        }
    }
}
