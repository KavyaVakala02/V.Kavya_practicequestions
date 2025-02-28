using System;

namespace practicequestions
{
    sealed class SecuritySystem
    {
        public void Authenticate()
        {
            Console.WriteLine("Security system authentication successful.");
        }

        public void LogAccess()
        {
            Console.WriteLine("Access logged in the security system.");
        }
    }
}
