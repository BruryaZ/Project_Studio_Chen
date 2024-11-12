namespace ClassLibraries
{
    public class Person
    {
        static int count = 1;
        private string id;

        public string Id
        {
            get { return id; }
        }
        public string Identity { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public Person(string identity, string firstName, string lastName, string phone, string email, string address)
        {
            this.id = (count++).ToString();
            Identity = identity;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Email = email;
            Address = address;
        }
        public Person()
        {
            this.id = (count++).ToString();
        }
    }
}