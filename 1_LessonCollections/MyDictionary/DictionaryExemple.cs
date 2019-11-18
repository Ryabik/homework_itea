using _1_LessonCollections.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_LessonCollections.MyDictionary
{
    public class DictionaryExemple
    {
        public static void MyDictionary()
        {
            Dictionary<IKey, IValue> entities = new Dictionary<IKey, IValue>();

            FirstItem id = new FirstItem(1);
            SecondItem number = new SecondItem(2);
            ThirdItem value = new ThirdItem("Sabaton");
            FourthItem name = new FourthItem("Iron Maiden");

            entities.Add(id, value);
            entities.Add(number, name);

            foreach(var item in entities)
            {
                Console.WriteLine($"Dictionary key: {item.Key.ToString()} has value {item.Value.ToString()}");
            }
        }
    }
}
