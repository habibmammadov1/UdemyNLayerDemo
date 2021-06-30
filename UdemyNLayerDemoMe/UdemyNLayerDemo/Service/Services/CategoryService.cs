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
    public class CategoryService : Service<Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork, IRepository<Category> repository) : base(unitOfWork, repository)
        {

        }

        public async Task<Category> GetWithProductsByIdAsync(int id)
        {
            return await _unitOfWork.Categories.GetWithProductsByIdAsync(id);
        }
    }
}
