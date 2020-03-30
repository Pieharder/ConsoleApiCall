using System;
using System.Threading.Tasks;
using RestSharp;

namespace ApiTest
{
  class Program
  {
    static void Main()
    {
      var apiCallTask = ApiHelper.ApiCall("[QJmUAg80RmZlE8EF0Nbhq5smFHmX0zqA]");
      var result = apiCallTask.Result;
      Console.WriteLine(result);
    }
  }

  class ApiHelper
  {
    public static async Task<string> ApiCall(string apiKey)
    {
      RestClient client = new RestClient("https://api.nytimes.com/svc/topstories/v2");
      RestRequest request = new RestRequest($"home.json?api-key={apiKey}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}