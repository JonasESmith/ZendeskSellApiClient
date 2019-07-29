using System;
using RestSharp;
using Zendesk.Deal;
using Zendesk.Task;
using Zendesk.Lead;
using Zendesk.Order;
using Zendesk.LineItem;
using Zendesk.Products;

namespace Zendesk
{
  public class ZendeskApi
  {
    public string authorizationString { get; set; }

    /// <summary>
    /// Object Constructor for Zendesk Item!
    /// </summary>
    public ZendeskApi(string _auth)
    {
      authorizationString = _auth;
    }

    /***********************************************/
    /*                 Deals                       */
    /***********************************************/
    #region Deals
    /// <summary>
    /// Returns JSon Data associated with the dealID passed.
    /// The authorizationString will look like "Bearer xxx....."
    /// </summary>
    /// <param name="authorizationString"></param>
    /// <param name="dealID"></param>
    /// <returns></returns>
    public string GetDeal( string dealID)
    {
      var client     = new RestClient();
      client.BaseUrl = new Uri("https://api.getbase.com/v2");
      var request    = new RestRequest(string.Format("https://api.getbase.com/v2/deals/{0}", dealID), Method.GET)
                           .AddHeader("Accept", "application/json")
                           .AddHeader("Authorization", authorizationString);

      var response = client.Execute(request);
      return response.Content;
    }


    /// <summary>
    /// Takes a CreateDealObject  Object and Posts it to Zendesk will return a json String
    /// </summary>
    /// <param name="authorizationString"></param>
    /// <param name="deal"></param>
    /// <returns></returns>
    public string CreateDeal( CreateDealObject deal)
    {
      var client             = new RestClient() { BaseUrl = new Uri("https://api.getbase.com/v2/") };
      var request            = new RestRequest("https://api.getbase.com/v2/deals", Method.POST) { RequestFormat = DataFormat.Json };
      request.JsonSerializer = new RestSharpJsonNetSerializer();

      request.AddHeader("Accept", "application/json")
             .AddHeader("Content-Type", " application/json")
             .AddHeader("Authorization", authorizationString);
      request.AddJsonBody(deal);

      var reponse = client.Execute(request);

      return reponse.Content;
    }

    /// <summary>
    /// Create a UpdateDealObject and pass it all the variables from the original deal only updating the values you want to update form the original
    /// this will return a json String
    /// </summary>
    /// <param name="authorizationString"></param>
    /// <param name="updatedDeal"></param>
    /// <param name="dealID"></param>
    /// <returns></returns>
    public string UpdateDeal( UpdateDealObject updatedDeal, string dealID)
    {
      var client             = new RestClient() { BaseUrl = new Uri(" https://api.getbase.com/v2/") };
      var request            = new RestRequest(string.Format(" https://api.getbase.com/v2/deals/{0}", dealID), Method.PUT) { RequestFormat = DataFormat.Json };
      request.JsonSerializer = new RestSharpJsonNetSerializer();

      request.AddHeader("Accept", "application/json")
             .AddHeader("Content-Type", "application/json")
             .AddHeader("Authorization", "Bearer 569ff471e1fb35bdb0f86e0a521e456ae5d45912947ce1c9514946e2446a3bf0");
      request.AddJsonBody(updatedDeal);

      var response = client.Execute(request);
      return response.Content;
    }


    #endregion



    /***********************************************/
    /*                 Tasks                       */
    /***********************************************/
    #region Tasks

    /// <summary>
    /// Creates a task with the information from the passed CreateTaskObject, for the account associated with the authorizationString and returns a json string.
    /// </summary>
    /// <param name="authorizationString"></param>
    /// <param name="task"></param>
    /// <returns></returns>
    public string CreateTask( CreateTaskObject task)
    {
      var client             = new RestClient() { BaseUrl = new Uri("https://api.getbase.com/v2/") };
      var request            = new RestRequest("https://api.getbase.com/v2/tasks", Method.POST) { RequestFormat = DataFormat.Json };
      request.JsonSerializer = new RestSharpJsonNetSerializer();

      request.AddHeader("Accept", "application/json")
             .AddHeader("Content-Type", "application/json")
             .AddHeader("Authorization", authorizationString);
      request.AddJsonBody(task);

      var response = client.Execute(request);

      return response.Content;
    }


    #endregion




    /***********************************************/
    /*                 Leads                       */
    /***********************************************/
    #region Leads 

    /// <summary>
    /// Creates a new lead with the passed CreateLeadObject associated with this method and returns a json string
    /// </summary>
    /// <param name="authorizationString"></param>
    /// <param name="task"></param>
    /// <returns></returns>
    public string CreateLead( CreateLeadObject lead)
    {
      var client             = new RestClient() { BaseUrl = new Uri("https://api.getbase.com/v2/") };
      var request            = new RestRequest("https://api.getbase.com/v2/leads", Method.POST) { RequestFormat = DataFormat.Json };
      request.JsonSerializer = new RestSharpJsonNetSerializer();

      request.AddHeader("Accept", "application/json")
             .AddHeader("Content-Type", "application/json")
             .AddHeader("Authorization", authorizationString);
      request.AddJsonBody(lead);

      var response = client.Execute(request);

      return response.Content;
    }


    #endregion



    /***********************************************/
    /*                 Orders                      */
    /***********************************************/
    #region Orders

    /// <summary>
    /// Gets the order associated with the Deal ID passed and returns a json string
    /// </summary>
    /// <param name="authorizationString"></param>
    /// <param name="task"></param>
    /// <returns></returns>
    public string GetOrder_ByDealId( string dealID)
    {
      var client             = new RestClient();
      client.BaseUrl         = new Uri("https://api.getbase.com/v2/");
      var request            = new RestRequest("https://api.getbase.com/v2/orders", Method.GET) { RequestFormat = DataFormat.Json };
      request.AddHeader("Accept", "application/json")
             .AddHeader("Authorization", authorizationString)
             .AddParameter("deal_id", dealID);

      var response = client.Execute(request);
      return response.Content;
    }


    /// <summary>
    /// Takes a lineItem object and will add it to an order with the corresponding orderId passed returns json string of the results
    /// </summary>
    /// <param name="authorizationString"></param>
    /// <param name="lineItem"></param>
    /// <param name="orderID"></param>
    /// <returns></returns>
    public string AddALineItemToOrder( LineItemObject lineItem, string orderID)
    {
      var client      = new RestClient() { BaseUrl = new Uri("https://api.getbase.com/v2/") };
      var request     = new RestRequest(string.Format("https://api.getbase.com/v2/orders/{0}/line_items", orderID), Method.POST)
      { RequestFormat = DataFormat.Json, JsonSerializer = new RestSharpJsonNetSerializer() };

      request.AddHeader("Accept", "application/json")
             .AddHeader("Content-Type", " application/json")
             .AddHeader("Authorization", authorizationString);

      request.AddJsonBody(lineItem);

      var response = client.Execute(request);
      return response.Content;
    }

    #endregion


    /***********************************************/
    /*                 Products                    */
    /***********************************************/
    #region Products

    public string GetProducts(int page_number, int number_per_page) {
      var client = new RestClient();
      client.BaseUrl = new Uri("https://api.getbase.com/v2");
      var request = new RestRequest("https://api.getbase.com/v2/products", Method.GET)
                        .AddParameter("page", page_number)
                        .AddParameter("per_page", number_per_page)
                        .AddHeader("Accept", "application/json")
                        .AddHeader("Authorization", authorizationString);

      var response = client.Execute(request);

      return response.Content;
    }

    public string CreateProduct(NewProductObject product) {

      var client = new RestClient() { BaseUrl = new Uri("https://api.getbase.com/v2/") };
      var request = new RestRequest("https://api.getbase.com/v2/products", Method.POST) { RequestFormat = DataFormat.Json };
      request.JsonSerializer = new RestSharpJsonNetSerializer();

      request.AddHeader("Accept", "application/json")
             .AddHeader("Content-Type", "application/json")
             .AddHeader("Authorization", authorizationString);
      request.AddJsonBody(product);

      var response = client.Execute(request);

      return response.Content;
    }
    #endregion

  }
}
