using System;

namespace ItemLibrary
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Quality { get; set; }
        public int Quantity { get; set; }

        public Item(int id, string name, string quality, int quantity)
        {
            Id = id;
            Name = name;
            Quality = quality;
            Quantity = quantity;
        }
        public override string ToString()
        {
            return $"{Id}-{Name}-{Quality}-{Quantity}";
        }
    }
}
