using Core.Entities;
using Core.Repositories;
using Core.Service;
using Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ProductService : Service<Product>, IProductService
    {

        public ProductService(IUnitOfWork unitOfWork, IRepository<Product> repository) : base(unitOfWork, repository)
        {

        }

        public async Task<Product> GetWithCategoryByIdAsync(int id)
        {
            return await _unitOfWork.Products.GetWithCategoryByIdAsync(id);
        }
    }
}
