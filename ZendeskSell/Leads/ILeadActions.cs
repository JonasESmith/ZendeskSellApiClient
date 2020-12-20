namespace Zendesk.Leads
{
    public interface ILeadActions
    {
        string Create(CreateLeadObject lead);
    }
}