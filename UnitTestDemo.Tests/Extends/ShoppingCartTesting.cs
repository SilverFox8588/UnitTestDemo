using System.Collections.Generic;
using UnitTestDemo.common;
using UnitTestDemo.Models;

namespace UnitTestDemo.Tests.Extends
{
    public class ShoppingCartTesting : ShoppingCart
    {
        public Dictionary<Item, int> Items { get { return _items; } }
    }
}
