using System.Collections.Generic;

namespace Constructors
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        // Contstructor will be chosen based on the parameters passed
        /// Typically this is bad practice
        /// Use min amount of constructors and this()

        // Declare constructor
        public Customer(int id) 
            // Call default constructor to initialize List
            : this()
        {
            this.Id = id;
        }

        // Overload constructor
        public Customer(int id, string name)
            // Call default constructor to initialize List and pass id
            :this(id)
        {
            this.Id = id;
            this.Name = name;
        }

        // Parameterless Contrcutor (Default)
        public Customer()
        {
            Orders = new List<Order>();
        }
    }
}