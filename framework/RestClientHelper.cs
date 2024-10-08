using AmusedAutomation.config;
using RestSharp;
using NLog;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;

public class RestClientHelper
{
    private readonly RestClient _client;
        
    public RestClientHelper(string baseUrl)
    {        
        _client = new RestClient(baseUrl);    
    }

    // Common method for API requests
    public RestResponse SendRequest(Method method, string endpoint, object body = null)
    {
        var request = new RestRequest(endpoint, method);

        if (body != null)
        {
            string jsonBody = JsonConvert.SerializeObject(body);
            request.AddJsonBody(jsonBody);
        }

        Logger.LogRequest(request);

        return _client.Execute(request);
    }

    public T DeserializeResponse<T>(RestResponse response)
    {
        Logger.LogResponse(response);
        return JsonConvert.DeserializeObject<T>(response.Content);
    }    
}
