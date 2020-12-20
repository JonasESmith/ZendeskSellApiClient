namespace Zendesk.Contacts
{
    public interface IContactActions
    {

        string Get(int pageNumber, int numPerPage);

        string Create(CreateContactObject contact);
    }
}