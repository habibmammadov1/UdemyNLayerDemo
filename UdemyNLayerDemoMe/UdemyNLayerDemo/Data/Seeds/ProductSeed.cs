using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        private int[] _ids;

        public ProductSeed(int[] ids)
        {
            _ids = ids;
        }
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, Name = "Pen", Price = 15, Stock = 5, CategoryId = _ids[0]},
                new Product { Id = 2, Name = "Pencil", Price = 20, Stock = 10, CategoryId = _ids[0]},
                new Product { Id = 3, Name = "Book", Price = 2, Stock = 7, CategoryId = _ids[1]},
                new Product { Id = 4, Name = "Notebook", Price = 10, Stock = 8, CategoryId = _ids[1]},
                new Product { Id = 5, Name = "Computer", Price = 90, Stock = 10, CategoryId = _ids[1]}
                );
        }
    }
}
