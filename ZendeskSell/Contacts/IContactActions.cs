using System.Threading.Tasks;
using ZendeskSell.Models;

namespace ZendeskSell.Contacts
{
    public interface IContactActions
    {

        Task<ZendeskSellCollectionResponse<ContactResponse>> GetAsync(int pageNumber, int numPerPage);

        Task<ZendeskSellObjectResponse<ContactResponse>> CreateAsync(ContactRequest contact);
    }
}