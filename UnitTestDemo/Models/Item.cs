using UnitTestDemo.common;

namespace UnitTestDemo.Models
{
    public class Item
    {
        public Item()
        {
            ItemType = ItemType.Car;
        }
        public ItemType ItemType { get; set; }
    }
}