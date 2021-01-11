using System.Threading.Tasks;
using ZendeskSell.Models;
using ZendeskSell.Orders;

namespace ZendeskSell.Products
{
    public interface IProductActions
    {
        Task<ZendeskSellCollectionResponse<ProductResponse>> GetAsync(int pageNumber, int numPerPage);

        Task<ZendeskSellObjectResponse<ProductResponse>> CreateAsync(ProductRequest product);
    }
}