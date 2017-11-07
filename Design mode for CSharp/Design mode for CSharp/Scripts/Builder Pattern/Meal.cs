using System;
using System.Collections.Generic;

namespace Design_mode_for_CSharp.Scripts.Builder_Pattern
{
    public class Meal
    {
        private List<IItem> items = new List<IItem>();

        public void addItem(IItem item)
        {
            items.Add(item);
        }

        public float getCost()
        {
            float cost = 0.0f;
            foreach (IItem item in items)
            {
                cost += item.price();
            }
            return cost;
        }

        public void showItems()
        {
            foreach (IItem item in items)
            {
                Console.WriteLine("Item : " + item.name());
                Console.WriteLine(", Packing : " + item.packing().pack());
                Console.WriteLine(", Price : " + item.price());
            }
        }
    }
}