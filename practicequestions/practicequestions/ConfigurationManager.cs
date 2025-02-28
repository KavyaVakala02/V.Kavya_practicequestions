using System;

namespace practicequestions
{
    class ConfigurationManager
    {
        private static ConfigurationManager _instance;
        private static readonly object _lock = new object();
        public string ConfigData { get; private set; }

        // Private constructor to prevent external instantiation
        private ConfigurationManager()
        {
            ConfigData = "Default Configuration";
        }

        // Thread-safe Singleton instance retrieval
        public static ConfigurationManager GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ConfigurationManager();
                    }
                }
            }
            return _instance;
        }

        // Method to update configuration data
        public void UpdateConfig(string newConfig)
        {
            ConfigData = newConfig;
            Console.WriteLine($"Configuration updated: {ConfigData}");

            Console.WriteLine("=== Thread-Safe Singleton Configuration Manager ===");

            // Retrieve the singleton instance
            ConfigurationManager config1 = ConfigurationManager.GetInstance();
            config1.UpdateConfig("Database Connection: SecureMode");

            // Retrieve another instance (same object)
            ConfigurationManager config2 = ConfigurationManager.GetInstance();
            Console.WriteLine($"Config in second instance: {config2.ConfigData}");

            // Confirm both instances are the same
            Console.WriteLine($"Are config1 and config2 the same instance? {ReferenceEquals(config1, config2)}");
        }
    }
}
