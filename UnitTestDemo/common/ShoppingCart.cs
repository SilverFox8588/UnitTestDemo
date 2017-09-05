using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnitTestDemo.Models;

namespace UnitTestDemo.common
{
    public class ShoppingCart
    {
        private Dictionary<Item, int> items = new Dictionary<Item, int>();
        private Hashtable hashtable = new Hashtable();

        /// <summary>
        /// Adds the items.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="quantity">The quantity.</param>
        public void AddItems(Item item, int quantity)
        {
            items.Add(item, quantity);

            //if (quantity > 0)
            //{
            //    if (items.ContainsKey(item))
            //    {
            //        items[item] += quantity;
            //    }
            //    else
            //    {
            //        items.Add(item, quantity);
            //    }
            //}
            //else
            //{
            //    throw new ArgumentException("The quantity cannot be under zero.");
            //}
            //hashtable.Add(item, quantity);
        }

        public void DeleteItems(Item item, int quantity)
        {
            items[item] = items[item] - quantity;
            //hashtable[item] = items[item] = quantity;
        }

        /// <summary>
        /// Gets the total count of all type of items.
        /// </summary>
        /// <value>
        /// The item count.
        /// </value>
        public int ItemCount
        {
            get
            {
                return items.Count;
                //return items.Sum(x => x.Value);
            }
        }
    }
}