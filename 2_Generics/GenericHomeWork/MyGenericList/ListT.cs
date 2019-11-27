using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyGenericList
{
    public class MyList<T> : IEnumerable
    {
        public List<T> GenericList { get; set; }
        public IEnumerator GetEnumerator()
        {
            return new Iterator<T>(this.GenericList);
        }

    }

    internal class Iterator<T> : IEnumerator
    {
        private List<T> genList;

        public Iterator(List<T> list)
        {
            this.genList = list;
        }

        int currentPosition = -1;

        public object Current
        {
            get
            {
                return genList[currentPosition];
            }
        }
        public bool MoveNext()
        {
            if (currentPosition < genList.Count - 1)
            {
                currentPosition++;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            currentPosition = -1;
        }
        
        public void Add(T item)
        {
            genList.Add(item); 
           
        }
        public void Remove(T item)
        {
            if (genList.Count > 5)
            {
                genList.Remove(item);
            }
            else
            {
                Console.WriteLine($"there are not enough elements in collection to delete something. Need more {6 - genList.Count} element");
            }
        }

            //Add и Remove.
            //    Элемент в коллекцию должен добавляться только если он соотвествует типу, укзаному вами в List.
            //    Удаляться элемент должен только если коллекция содержит больше 5 элементов.
     }
}
