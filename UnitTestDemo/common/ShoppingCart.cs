using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnitTestDemo.Models;

namespace UnitTestDemo.common
{
    public class ShoppingCart
    {
        private Dictionary<Item, int> _items = new Dictionary<Item, int>();
        private Hashtable _hashtable = new Hashtable();

        /// <summary>
        /// Adds the items.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="quantity">The quantity.</param>
        public void AddItems(Item item, int quantity)
        {
            _items.Add(item, quantity);

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
            _items[item] = _items[item] - quantity;

            //if (items.ContainsKey(item))
            //{
            //    if (items[item] > quantity)
            //    {
            //        items[item] = items[item] - quantity;
            //    }
            //    else if (items[item] == quantity)
            //    {
            //        items.Remove(item);
            //    }
            //    else
            //    {
            //        throw new ArgumentException("The quantity is larger than that in shopping cart.");
            //    }
            //}
            //hashtable[item] = items[item] = quantity;
        }

        /// <summary>
        /// Gets the total count of all type of items.
        /// </summary>
        /// <value>
        /// The item count.
        /// </value>
        public int TotalItemsCount
        {
            get
            {
                return _items.Sum(x => x.Value);
            }
        }
    }
}