using System.Threading.Tasks;

namespace ZendeskSell.Deals
{
    public interface IDealActions
    {
        Task<ZendeskSellObjectResponse<DealResponse>> GetAsync(int dealID);
        Task<ZendeskSellCollectionResponse<DealResponse>> GetByNameAsync(string dealName);
        Task<ZendeskSellObjectResponse<DealResponse>> CreateAsync(DealRequest deal);
        Task<ZendeskSellObjectResponse<DealResponse>> CreateAsync(DealByOwnerRequest deal);
        Task<ZendeskSellObjectResponse<DealResponse>> UpdateAsync(int dealId, DealResponse updatedDeal);
    }
}