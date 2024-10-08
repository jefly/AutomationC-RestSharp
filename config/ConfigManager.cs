namespace AmusedAutomation.config
{
    public sealed class ConfigManager
    {   
        private static ConfigManager _instance;
        
        private ConfigManager()
        {
            
        }
        public static ConfigManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ConfigManager();
                }
                return _instance;
            }
        }

        public string GetBaseUrl()
        {
            return System.Configuration.ConfigurationManager.AppSettings["BaseUrl"]!;
        }
    }
}
