using RestSharp;

public static class Logger {
    private static readonly NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

    public static void LogRequest(RestRequest request)
    {
        _logger.Info($"Request: {request.Method} {request.Resource}");
    }

    public static void LogResponse(RestResponse response)
    {
        _logger.Info($"Response: {response.StatusCode}, Content: {response.Content}");
    }
}
