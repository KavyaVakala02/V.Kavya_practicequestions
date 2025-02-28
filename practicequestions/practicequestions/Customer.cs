using System;

namespace practicequestions
{
    class Customer : User
    {
        public Customer(string username) : base(username, "Customer") { }

        public override void AccessControl()
        {
            Console.WriteLine($"{Username} (Customer) has limited access to basic features.");
        }
    }
}
