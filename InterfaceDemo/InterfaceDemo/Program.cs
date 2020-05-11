
using System;
namespace Console_Application_Interface
{
    interface ICustomer
    {
        void print();

    }
    interface I2Customer : ICustomer
    {
        void display();
    }
    public class Customer : I2Customer
    {
        public void print()
        {
            Console.WriteLine("Print method of interface 1");
            

        }
        public void display()
        {
            Console.WriteLine("Display method of interface 2");
            
        }


    }

    public class Program
    {
        public static void Main(string[] args)
        {

            Customer C1 = new Customer();
            C1.print();
            C1.display();

        }
    }
}