using System;
using System.Collections.Generic;
using System.Text;

namespace _1_LessonCollections.Collections
{
    public static class LinkedListGeneric
    {
        public static void Manipulations()
        {
            LinkedList<string> year = new LinkedList<string>();

            year.AddFirst("January");
            year.AddAfter(year.Last, "February");
            year.AddAfter(year.Last, "March");
            year.AddAfter(year.Last, "April");
            year.AddAfter(year.Last, "May");
            year.AddAfter(year.Last, "June");
            year.AddAfter(year.Last, "June");
            year.AddAfter(year.Last, "July");
            year.AddAfter(year.Last, "August");
            year.AddAfter(year.Last, "September");
            year.AddAfter(year.Last, "October");
            year.AddAfter(year.Last, "November");
            year.AddLast( "December");

            LinkedListNode<string> month = year.First;
            while (month != null)
            {
                Console.WriteLine(month.Value);
                month = month.Next;
            }
            Console.WriteLine("\n ERROR: month doubles \"June\"!");

            month = year.First;
            while (month != null)
            {
                Console.WriteLine(month.Value);
                if (month.Equals(month.Next))
                {
                    month.Next.Value.Replace(month.Value,"corrected");
                }
                month = month.Next;
            } //Удалить или исправить так и не получилось.
            
        }
    }
}
