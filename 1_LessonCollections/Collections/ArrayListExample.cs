using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _1_LessonCollections.Collections
{
    public static class ArrayListExample
    {
        public static void MyArrayList()
        {
            ArrayList myArrayList = new ArrayList();

            myArrayList.Add(2017);
            myArrayList.Add("the normal year");
            myArrayList.Add(false);
            myArrayList.Add("Funny elements");

            foreach (var item in myArrayList)
            {
                Console.WriteLine($"item {myArrayList.IndexOf(item)} {item.GetType()} of my arrayList: {item}");
            }
        }
    }
}
