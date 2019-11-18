using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _1_LessonCollections.Collections
{
    public class QueueExample
    {
        public static void MyQueue()
        {

            Queue myQueue = new Queue();

            myQueue.Enqueue("Item object");
            myQueue.Enqueue("New object");
            myQueue.Enqueue("First entity");
            myQueue.Enqueue("Second entity");
            myQueue.Enqueue("Third entity");

            

            Console.WriteLine("---foreach Variant of queue ----");
            foreach (var element in myQueue)
            {
                Console.WriteLine($"Element :  {element} ");
            }

            Console.WriteLine("---basic FOR of queue ----");
            int count = myQueue.Count;
            for (int i = 0; i < count; i++)
            {
                var element = myQueue.Dequeue(); 
                Console.WriteLine($"Element {i}: {element} ");
            }

        }
    }
}
