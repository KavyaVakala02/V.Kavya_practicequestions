using System;

namespace practicequestions
{
    class Data_Hiding_with_Properties
    {
        private string name;
        private int rollNo;

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    name = value;
                else
                    Console.WriteLine("Error: Name cannot be empty.");
            }
        }

        public int RollNo
        {
            get { return rollNo; }
            set
            {
                if (value >= 0)
                    rollNo = value;
                else
                    Console.WriteLine("Error: Roll number cannot be negative.");
            }
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Student Name: {name}, Roll No: {rollNo}");
        }
    }
}
