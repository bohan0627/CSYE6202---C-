using System;
namespace BoHan_SOLID
{
    public class Product
    {
        public int Id { set; get; }
        public decimal Price { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public Product()
        {
        }
    }
}
