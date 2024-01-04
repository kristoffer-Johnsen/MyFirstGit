

namespace Lagerstyringssytem.Products
{
    internal class clothes : IProduct
    {
        public string Name { get; set; }
        public int Price { get; set; }

        private string _size;

        public clothes(string size, string name, int price)
        {
            _size = size;
            Name = name;
            Price = price;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{Name}  :   {Price}$\n" +
                              $"Size    :   {_size}");
        }
    }
}
