using Zendesk.Deal;

namespace Zendesk.Deals
{
    public interface IDealActions
    {
        string Get(string dealID);
        string GetByName(string dealName);
        string Create(CreateDealObject deal);
        string Create(CreateDealObjectWOwner deal);
        string Update(UpdateDealObject updatedDeal, string dealID);
    }
}