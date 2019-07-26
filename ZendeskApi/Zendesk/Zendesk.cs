using Newtonsoft.Json;
using RestSharp;
using System;
using Zendesk.Deal;
using Zendesk.Task;
using Zendesk.Lead;
using Zendesk.Order;
using Zendesk.LineItem;

namespace Zendesk
{
  public class Zendesk
  {

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
    public string GetDeal(string authorizationString, string dealID)
    {
      var client = new RestClient();
      client.BaseUrl = new Uri("https://api.getbase.com/v2");
      var request = new RestRequest(string.Format("https://api.getbase.com/v2/deals/{0}", dealID), Method.GET)
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
    public string CreateDeal(string authorizationString, CreateDealObject deal)
    {
      var client             = new RestClient() { BaseUrl = new Uri("https://api.getbase.com/v2/") };
      var request            = new RestRequest("https://api.getbase.com/v2/deals", Method.POST) { RequestFormat = DataFormat.Json };
      request.JsonSerializer = new RestSharpJsonNetSerializer();

      request.AddHeader("Accept", "application/json")
             .AddHeader("Content-Type", " application/json")
             .AddHeader("Authorization", "");
      request.AddJsonBody(deal);

      var reponse = client.Execute(request);

      return reponse.Content;
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
    public string CreateTask(string authorizationString, CreateTaskObject task)
    {
      var client = new RestClient() { BaseUrl = new Uri("https://api.getbase.com/v2/") };
      var request = new RestRequest("https://api.getbase.com/v2/tasks", Method.POST) { RequestFormat = DataFormat.Json };
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
    #region Tasks

    /// <summary>
    /// Creates a new lead with the passed CreateLeadObject associated with this method and returns a json string
    /// </summary>
    /// <param name="authorizationString"></param>
    /// <param name="task"></param>
    /// <returns></returns>
    public string CreateLead(string authorizationString, CreateLeadObject lead)
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
    /*                 Order                       */
    /***********************************************/
    #region Tasks

    /// <summary>
    /// Gets the order associated with the Deal ID passed and returns a json string
    /// </summary>
    /// <param name="authorizationString"></param>
    /// <param name="task"></param>
    /// <returns></returns>
    public string GetOrder_ByDealId(string authorizationString, string dealID)
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
    public string AddLineItemToOrder(string authorizationString, LineItemObject lineItem, string orderID)
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
  }
}
