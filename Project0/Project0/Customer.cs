using System;

namespace Project
{
    public class Customer
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        public Customer(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}

