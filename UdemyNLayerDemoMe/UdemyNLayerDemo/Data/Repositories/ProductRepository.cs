using Core.Entities;
using Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private AppDbContext _appDbContext { get => _dbContext as AppDbContext; }
        public ProductRepository(AppDbContext context) : base(context)
        {

        }
        public async Task<Product> GetWithCategoryByIdAsync(int id)
        {
            return await _appDbContext.Products.Include(x => x.Category).SingleOrDefaultAsync(x => x.Id == id);
        }
    }
}
