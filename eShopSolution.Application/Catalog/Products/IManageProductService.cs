
using eShopSolution.ViewModels.Catalog.ProductImages;
using eShopSolution.ViewModels.Catalog.Products;

using eShopSolution.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);

        Task<int> Delete(int productID);
        Task<ProductViewModel> GetById(int productID, string languageId);
        Task<bool> UpdatePrice(int productId, decimal newprice);
        Task<bool> UpdateStock(int productId, int addedQuantity);

        Task AddViewCount(int productId);
   
        Task<PageResult<ProductViewModel>> GetALLPaging(GetManageProductPagingRequest request);
        
        Task<int> AddImage(int productId, ProductImageCreateRequest request);
        Task<int> RemoveImage(int imageId);
        Task<int> UpdateImage(int imageId, ProductImageUpdateRequest request);
        Task<List<ProductImageViewModel>>GetListImages(int productId);

        Task<ProductImageViewModel> GetImageById(int imageId);
    }
}
