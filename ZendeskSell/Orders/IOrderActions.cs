using Zendesk.LineItems;

namespace Zendesk.Orders
{
    public interface IOrderActions
    {
        string GetByDealID(string dealID);
        
        string Create(NewOrderObject order);

        string AddLineItem(LineItemObject lineItem, string orderID);
    }
}