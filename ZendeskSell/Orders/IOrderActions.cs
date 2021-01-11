using System.Threading.Tasks;
using ZendeskSell.LineItems;
using ZendeskSell.Models;

namespace ZendeskSell.Orders
{
    public interface IOrderActions
    {
        Task<ZendeskSellObjectResponse<OrderResponse>> GetByDealIDAsync(int dealID);

        Task<ZendeskSellObjectResponse<OrderResponse>> CreateAsync(OrderRequest order);

        Task<ZendeskSellObjectResponse<OrderResponse>> AddLineItemAsync(LineItemData lineItem, int orderID);
    }
}