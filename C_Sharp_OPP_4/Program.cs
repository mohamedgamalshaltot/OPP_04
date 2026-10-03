namespace C_Sharp_OPP_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1  Abstraction
            // a)  What is Abstraction in Object-Oriented Programming?
            //Abstraction is hiding the complex implementation details of an object and showing only the essential features to the user (achieved in C# via ⁠abstract⁠ classes and ⁠interfaces⁠).
            //b)  Why is abstraction considered one of the four pillars of OOP?
            //Abstraction is considered one of the four pillars of OOP because it allows developers to create a clear separation between the interface and implementation of an object, making it easier to manage complexity and improve code maintainability.
            #endregion
            #region Q2  Abstract Classes vs. Interfaces
            //a)  What is the difference between an Abstract Class and an Interface?
            // An Abstract Class represents an "is-a" relationship, allows code implementation, and supports single inheritance only.
            // An Interface represents a "can-do" capability, defines a contract without state, and allows multiple implementation.
            //b)  When would you choose an Interface instead of an Abstract Class?
            // You would choose an Interface when you want to define a contract that multiple classes can implement, especially when those classes do not share a common base class. Interfaces are also preferred when you need to support multiple inheritance of behavior.
            //c)  Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?
            // A class cannot inherit from multiple abstract classes due to C#'s single inheritance model. However, a class can implement multiple interfaces, allowing it to inherit behavior from multiple sources.
            #endregion
            #region Part 02 — Practical
            // Address initialization
            DeliveryAddress address = new DeliveryAddress();
           
            // a. Create one StandardShipment
            StandardShipment standard = new StandardShipment("SH001", "Laptop", 3m, 80m, address);

            // b. Create one ExpressShipment (Extra Fee = 30 EGP based on expected output)
            ExpressShipment express = new ExpressShipment("SH002", "Documents", 1m, 70m, address, 30m);

            // c. Create one InternationalShipment
            InternationalShipment international = new InternationalShipment("SH003", "Germany", 5m, 200m, address);

            // d. Add all shipments to the DeliveryCenter
            DeliveryCenter center = new DeliveryCenter("Cairo Central Hub");
            center.AddShipment(standard);
            center.AddShipment(express);
            center.AddShipment(international);

            // e. Print all shipment details
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Delivery Center");
            Console.WriteLine("--------------------------------------------------");
            center.PrintAllShipments();

            // f. Print the tracking status of every shipment
            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine("Tracking Status");
            Console.WriteLine("--------------------------------------------------");
            center.PrintTrackingStatus();

            // g. Print the insurance cost of every shipment
            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine("Insurance");
            Console.WriteLine("--------------------------------------------------");
            DeliveryReport.PrintInsurance(standard);
            DeliveryReport.PrintInsurance(express);
            DeliveryReport.PrintInsurance(international);

            // h & i. Polymorphism arrays
            ITrackable[] trackableShipments = new ITrackable[] { standard, express, international };
            IInsurable[] insurableShipments = new IInsurable[] { standard, express, international };

            Console.WriteLine("\nInterface Polymorphism Demonstrated Successfully.");

            #endregion
        }
    }
}
