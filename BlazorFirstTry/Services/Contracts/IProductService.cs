using ShopOnline.Models.Dtos;

namespace BlazorFirstTry.Services.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetItems();

    }
}
