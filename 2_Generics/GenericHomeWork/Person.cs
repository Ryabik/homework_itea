using System;
using System.Collections.Generic;
using System.Text;

namespace GenericPerson
{
    public class Person<T, R>
                    where T : struct
                    where R : Shape
    {
        public T Num { get; set; }
        public R Condition { get; set; }
        public Person (T num, R condition)
            {

            }
        public string ReturnCondition()
        {
          return $"The Shape has {Condition.form} and the colour is {Condition.colour}";
        }

    }
}
