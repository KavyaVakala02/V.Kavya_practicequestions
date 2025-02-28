using System;

namespace practicequestions
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void GetDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    class Student : Person
    {
        public int StudentId { get; set; }

        public Student(string name, int age, int studentId) : base(name, age)
        {
            StudentId = studentId;
        }

        public override void GetDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Student ID: {StudentId}");
        }
    }

    class Teacher : Person
    {
        public string Subject { get; set; }

        public Teacher(string name, int age, string subject) : base(name, age)
        {
            Subject = subject;
        }

        public override void GetDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Subject: {Subject}");
        }
    }

}
