using _1_LessonCollections.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_LessonCollections
{
    public class ThirdItem: IValue
    {
        

        string IValue.MyValue { get; set; }
        public ThirdItem(string v)
        {
        }
    }
}
