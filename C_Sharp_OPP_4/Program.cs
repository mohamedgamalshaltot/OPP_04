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
        }
    }
}
