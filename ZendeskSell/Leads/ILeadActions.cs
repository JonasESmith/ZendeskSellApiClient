using System.Threading.Tasks;
using ZendeskSell.Models;

namespace ZendeskSell.Leads
{
    public interface ILeadActions
    {
        Task<ZendeskSellObjectResponse<LeadResponse>> CreateAsync(LeadRequest lead);
    }
}