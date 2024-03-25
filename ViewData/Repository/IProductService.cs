using Microsoft.EntityFrameworkCore;
using System.Linq;
using ViewData.Data;
using ViewData.Models;

namespace ViewData.Repository
{
    public class ProductService :IProduct
    {
        private readonly ViewDataContext _context;

        public ProductService(ViewDataContext context)
        {
            _context = context;
        }

        public Product GetProduct(int id)
        {
            var product = _context.Product.FirstOrDefault(x => x.Id == id);
            return product;
        }
    }
}
