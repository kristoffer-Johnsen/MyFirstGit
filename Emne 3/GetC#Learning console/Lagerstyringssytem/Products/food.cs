

namespace Lagerstyringssytem.Products
{
    internal class food : IProduct
    {
        private int ShelfLife;
        public string Name { get; set; }
        public int Price { get; set; }

        public food(int shelfLife, string name, int price)
        {
            ShelfLife = shelfLife;
            Name = name;
            Price = price;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{Name}      :   {Price}$\n" +
                              $"ShelfLife   :   {ShelfLife} months from opening");
        }
    }
}
