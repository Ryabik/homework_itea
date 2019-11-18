using _1_LessonCollections.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_LessonCollections
{
    public class SecondItem : IKey
    {
         int IKey.MyKey { get; set; }
        public SecondItem(int id)
        {
        }
    }
}
