using System;
using Test__OOPs_Practical_Coding_Questions_;
using Test_OOPs_Practical_Coding_Questions;

namespace practicequestions
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("=== Bank Account System ===");

            // Creating account with default balance
            Bankaccount account1 = new Bankaccount();
            account1.DisplayBalance();

            // Creating account with initial balance
            Bankaccount account2 = new Bankaccount(500);
            account2.DisplayBalance();

            // Depositing money
            account2.Deposit(200);
            account2.DisplayBalance();

            // Withdrawing money
            account2.Withdraw(100);
            account2.DisplayBalance();

            // Attempting invalid withdrawal
            account2.Withdraw(700);
            account2.DisplayBalance();
            // === Book Constructor Overloading ===
            Console.WriteLine("\n=== Student Details ===");


            try
            {
                Students stu = new Students("John Doe", 101);
                stu.DisplayStudentInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("\n=== Library System ===");

            // Using Default Constructor
            Book book1 = new Book();
            book1.DisplayDetails();

            // Using Constructor with Title and Author
            Book book2 = new Book("The Great Gatsby", "F. Scott Fitzgerald");
            book2.DisplayDetails();

            // Using Constructor with Title, Author, and ISBN
            Book book3 = new Book("1984", "George Orwell", "978-0451524935");
            book3.DisplayDetails();

            Console.WriteLine("\n=== Vehicle System ===");

            // === Vehicle Method Overriding ===
            Console.WriteLine("=== Method Overriding in a Vehicle System ===");

            // Base class reference pointing to derived class objects
            Vehicle myCar = new Car();
            Vehicle myBike = new Bike();

            // Calling overridden methods
            myCar.Start();  // Calls Car's Start method
            myBike.Start(); // Calls Bike's Start method


            Console.WriteLine("\n=== Student Data Hiding with Properties ===");

            // Creating a Student object
            Data_Hiding_with_Properties student1 = new Data_Hiding_with_Properties();

            // Setting values
            student1.Name = "John Doe";
            student1.RollNo = 101;

            // Displaying student details
            student1.DisplayDetails();

            // Attempting invalid values
            student1.Name = "";
            student1.RollNo = -5;

            // Displaying student details after invalid attempts
            student1.DisplayDetails();

            Console.WriteLine("\n=== Shape Area Calculation ===");

            // Creating Circle instance
            Shape circle = new Circle(5);
            Console.WriteLine("Circle:");
            circle.DisplayArea();

            // Creating Rectangle instance
            Shape rectangle = new Rectangle(4, 6);
            Console.WriteLine("\nRectangle:");
            rectangle.DisplayArea();

            Console.WriteLine("=== Person Details ===");

            // Using base class reference for Student
            Person student = new Student("Alice", 20, 101);
            student.GetDetails();

            // Using base class reference for Teacher
            Person teacher = new Teacher("Mr. Smith", 40, "Mathematics");
            teacher.GetDetails();


            Console.WriteLine("\n=== Simple Calculator ===");

            Calculator calc = new Calculator();

            int num1 = 10, num2 = 5;

            Console.WriteLine($"Addition: {calc.Add(num1, num2)}");
            Console.WriteLine($"Subtraction: {calc.Subtract(num1, num2)}");
            Console.WriteLine($"Multiplication: {calc.Multiply(num1, num2)}");
            Console.WriteLine($"Division: {calc.Divide(num1, num2)}");

            Console.WriteLine("\n--- Interface Implementation Challenge ---");

            // Creating objects of MusicPlayer and VideoPlayer
            IPlayable musicPlayer = new MusicPlayer();
            IPlayable videoPlayer = new VideoPlayer();

            // Calling Play method for both objects
            musicPlayer.Play();  // Expected: Playing music...
            videoPlayer.Play();  // Expected: Playing video...

            Console.WriteLine("\n=== Multiple Inheritance Using Interfaces ===");

            Report myReport = new Report("Project Update", "The project is progressing on schedule.");

            // Using IPrintable interface
            myReport.Print();

            // Using ISerializable interface
            myReport.SaveToFile("report.txt");

            Console.WriteLine("\n=== Role-Based Access System ===");

            // Creating an Admin user
            User admin = new Admin("Alice");
            admin.AccessControl();

            // Creating a Customer user
            User customer = new Customer("Bob");
            customer.AccessControl();
            Console.WriteLine("=== Operator Overloading for Complex Numbers ===");

            // Creating two complex numbers
            ComplexNumber num3 = new ComplexNumber(3, 4);
            ComplexNumber num4 = new ComplexNumber(2, 5);

            // Adding complex numbers using overloaded +
            ComplexNumber result = num3 + num4; // Ensuring the result is of type ComplexNumber

            // Displaying results
            Console.Write("First ");
            num3.Display();
            Console.Write("Second ");
            num4.Display();
            Console.Write("Sum ");
            result.Display();

            Console.WriteLine("\n=== Shallow Copy vs. Deep Copy ===");

            // Original department object
            Manager manager1 = new Manager("Alice");
            Department dept1 = new Department("HR", manager1);

            // Performing shallow copy
            Department shallowCopy = dept1.ShallowCopy();

            // Performing deep copy
            Department deepCopy = dept1.DeepCopy();

            Console.WriteLine("Before Modification:");
            dept1.Display();
            shallowCopy.Display();
            deepCopy.Display();

            // Modifying manager name in the original object
            dept1.Manager.Name = "Bob";

            Console.WriteLine("\nAfter Modifying Original Manager Name:");
            dept1.Display();         // Affected
            shallowCopy.Display();   // Affected (same reference)
            deepCopy.Display();      // Unaffected (new instance)

            Console.WriteLine("\n=== Static Members in Banking System ===");

            // Creating bank accounts
            Bank acc1 = new Bank("Alice", 1000);
            Bank acc2 = new Bank("Bob", 2000);

            // Displaying initial account details
            acc1.DisplayAccountInfo();
            acc2.DisplayAccountInfo();

            // Updating interest rate using static method
            Bank.SetInterestRate(6.5);

            // Displaying account details after updating interest rate
            acc1.DisplayAccountInfo();
            acc2.DisplayAccountInfo();

            Console.WriteLine("\n=== Sealed Class in a Security System ===");

            // Creating an instance of the sealed class
            SecuritySystem security = new SecuritySystem();

            // Using methods of SecuritySystem
            security.Authenticate();
            security.LogAccess();

            Console.WriteLine("\n=== Event Handling with Delegates ===");

            // Create a button instance
            Button myButton = new Button();

            // Subscribe to the event with a valid method
            myButton.OnClick += new Button.ClickHandler(ButtonClicked);

            // Simulate button click
            myButton.Click();
        // Corrected: Static method for event handler
        static void ButtonClicked()
        {
            Console.WriteLine("Event triggered: Button was clicked!");
        }
            Console.WriteLine("\n=== Factory Pattern for Object Creation ===");

            // Creating an automobile using factory
            Transport myAutomobile = TransportFactory.GetTransport("Automobile");
            myAutomobile.Operate();

            // Creating a two-wheeler using factory
            Transport myTwoWheeler = TransportFactory.GetTransport("TwoWheeler");
            myTwoWheeler.Operate();

            Console.WriteLine("\n=== Decoders ===");
            // Create a basic FileLogger
            ILogger fileLoggers = new FileLogger();

            // Add timestamp logging
            ILogger timestampLogger = new TimestampLogger(fileLoggers);

            // Add error category logging
            ILogger errorLogger = new ErrorCategoryLogger(timestampLogger, "ERROR");

            // Log messages
            errorLogger.Log("This is a critical error!");
            errorLogger.Log("System crashed due to memory overflow.");

            Console.WriteLine("\n=== Observer Pattern for Notifications ===");

            // Create subject (publisher)
            NotificationSubject notificationService = new NotificationSubject();

            // Create observers (subscribers)
            INotificationObserver emailNotifier = new EmailNotifier();
            INotificationObserver smsNotifier = new SMSNotifier();

            // Attach observers
            notificationService.Attach(emailNotifier);
            notificationService.Attach(smsNotifier);

            // Send a notification
            notificationService.Notify("New message received!");

            // Detach an observer and send another notification
            notificationService.Detach(emailNotifier);
            notificationService.Notify("Another alert received!");

            Console.WriteLine("=== Strategy Pattern for Dynamic Discount Calculation ===");

            // Taking user input for total amount
            Console.Write("Enter total cart amount: ");
            double totalAmount = Convert.ToDouble(Console.ReadLine());

            ShoppingCart cart = new ShoppingCart(totalAmount);

            // Choosing a discount strategy dynamically
            Console.WriteLine("Select discount strategy: 1 - No Discount, 2 - 10% Discount, 3 - $20 Discount");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    cart.SetDiscountStrategy(new NoDiscount());
                    break;
                case 2:
                    cart.SetDiscountStrategy(new PercentageDiscount(10));
                    break;
                case 3:
                    cart.SetDiscountStrategy(new FixedAmountDiscount(20));
                    break;
                default:
                    Console.WriteLine("Invalid choice! No discount applied.");
                    cart.SetDiscountStrategy(new NoDiscount());
                    break;
            }

            // Applying discount and displaying final amount
            cart.ApplyDiscount();

        }
    }
}
