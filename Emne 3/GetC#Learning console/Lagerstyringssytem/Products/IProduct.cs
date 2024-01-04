
namespace Lagerstyringssytem.Products
{
    internal interface IProduct
    {
        string Name { get; set; }
        int Price { get; set; }
        void ShowInfo();
    }

}
