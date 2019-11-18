using _1_LessonCollections.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_LessonCollections
{
    public class FourthItem : IValue
    {
        string IValue.MyValue { get; set; }
        public FourthItem(string v)
        {
        }
    }
}
