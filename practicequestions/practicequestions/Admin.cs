using System;

namespace practicequestions
{
    class Admin : User
    {
        public Admin(string username) : base(username, "Admin") { }

        public override void AccessControl()
        {
            Console.WriteLine($"{Username} (Admin) has full access to all features.");
        }
    }
}
