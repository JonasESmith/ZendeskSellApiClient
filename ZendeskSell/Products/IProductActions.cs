namespace Zendesk.Products
{
    public interface IProductActions
    {
        string Get(int pageNumber, int numPerPage);

        string Create(NewProductObject product);
    }
}