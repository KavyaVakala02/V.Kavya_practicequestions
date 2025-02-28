using System;
using Test__OOPs_Practical_Coding_Questions_;

namespace Test__OOPs_Practical_Coding_Questions_
{
    public class Students
    {
        private string name;
        private int rollNo;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty or whitespace.");
                }
                name = value;
            }
        }

        public int RollNo
        {
            get { return rollNo; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Roll number cannot be negative.");
                }
                rollNo = value;
            }
        }

        public Students(string name, int rollNo)
        {
            Name = name;  // Calls the property setter for validation
            RollNo = rollNo;
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Student Name: {Name}, Roll No: {RollNo}");
        }
    }
}