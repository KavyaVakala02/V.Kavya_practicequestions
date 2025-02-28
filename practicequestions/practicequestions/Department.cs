using System;

namespace practicequestions
{
    class Manager
    {
        public string Name { get; set; }

        public Manager(string name)
        {
            Name = name;
        }
    }

    class Department
    {
        public string DeptName { get; set; }
        public Manager Manager { get; set; }

        public Department(string deptName, Manager manager)
        {
            DeptName = deptName;
            Manager = manager;
        }

        // Shallow Copy
        public Department ShallowCopy()
        {
            return (Department)this.MemberwiseClone();
        }

        // Deep Copy
        public Department DeepCopy()
        {
            return new Department(DeptName, new Manager(Manager.Name));
        }

        public void Display()
        {
            Console.WriteLine($"Department: {DeptName}, Manager: {Manager.Name}");
        }
    }
}
