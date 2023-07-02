﻿using BlazorFirstTry_API.Entities;

namespace BlazorFirstTry_API.Repositories.Contracts
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetItems();
        Task<IEnumerable<ProductCategory>> GetCategories();
        Task<IEnumerable<Product>> GetItem(int id);
        Task<IEnumerable<ProductCategory>> GetCategory(int id);

    }
}
