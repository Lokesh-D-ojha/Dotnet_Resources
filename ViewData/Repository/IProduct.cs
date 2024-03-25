using ViewData.Models;

namespace ViewData.Repository
{
    public interface IProduct
    {
        Product GetProduct(int id);
    }
}

