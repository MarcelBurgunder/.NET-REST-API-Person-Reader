namespace PersonApi.Models
{
    // Person class respresenting a single person, with their full name and phone number
    public class Person
    {
        // Member Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        // Empty Constructor - sets all properties to an empty string
        public Person()
        {
            this.FirstName = "";
            this.LastName = "";
            this.PhoneNumber = "";
        }

        // Main constructor - sets properties upon object creation 
        public Person(string firstName, string lastName, string phoneNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
        }
    }
};
