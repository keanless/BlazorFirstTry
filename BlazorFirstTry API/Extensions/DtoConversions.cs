﻿using BlazorFirstTry_API.Entities;
using ShopOnline.Models.Dtos;
using System.Runtime.CompilerServices;

namespace BlazorFirstTry_API.Extensions
{
    public static class DtoConversions
    {
        public static IEnumerable<ProductDto>
            ConvertToDto(
            this IEnumerable<Product> products, 
                 IEnumerable<ProductCategory> productCategories)
        {
            return (from product in products
                    join productCategory in productCategories
                    on product.CategoryId equals productCategory.Id
                    select new ProductDto
                    {
                        Id = product.Id,
                        Name = product.Name,
                        Description = product.Description,
                        ImageURL = product.ImageURL,
                        Price = product.Price,
                        Qty = product.Qty,
                        CategoryId = product.CategoryId,
                        CategoryName = product.Name
                    }
                    ).ToList();
        }
    }
}
