using System;

namespace practicequestions
{
    class TransportFactory
    {
        public static Transport GetTransport(string type)
        {
            return type.ToLower() switch
            {
                "automobile" => new Automobile(),
                "twowheeler" => new TwoWheeler(),
                _ => throw new ArgumentException("Invalid transport type")
            };
        }
    }
}
