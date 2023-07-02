﻿using BlazorFirstTry.Services.Contracts;
using ShopOnline.Models.Dtos;
using System.Net.Http.Json;

namespace BlazorFirstTry.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient httpClient;

        public ProductService(HttpClient httpClient)
         {
            this.httpClient = httpClient;
         }

        public async Task<IEnumerable<ProductDto>> GetItems()
        {
            try
            {
                var products = await this.httpClient.GetFromJsonAsync<IEnumerable<ProductDto>>("api/Product");
                return products;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
