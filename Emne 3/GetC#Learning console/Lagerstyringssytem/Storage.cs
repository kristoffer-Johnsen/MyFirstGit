
using Lagerstyringssytem.Products;

namespace Lagerstyringssytem
{
    internal class Storage
    {
        List<IProduct> _list = new();

        internal void add(IProduct product)
        {
            _list.Add(product);
        }
        internal void remove(IProduct product)
        {
            _list.Remove(product);
        }

        internal void show()
        {
            foreach (var product in _list)
            {
                product.ShowInfo();
            }
        }
    }
}
