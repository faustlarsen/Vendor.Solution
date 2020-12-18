using System.Collections.Generic;

namespace VendorTracker.Models
{
    public class Order
    {
        public string Name { get; set; }
        public int Id {get; }
        private static List<Order> _instances = new List<Order>{};

        public Order (string name)
        {
            Name = name;
            _instances.Add(this);
            Id = _instances.Count;
        }

        public static List<Order> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static Order Find(int findId)
        {
            return _instances[findId -1];
        }
    }
}