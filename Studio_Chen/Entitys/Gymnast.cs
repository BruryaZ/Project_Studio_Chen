using ClassLibraries;

namespace Studio_Chen.Entities
{
    public class Gymnast : Person
    {
        public Gymnast()
        {
        }

        public Gymnast( string identity, string firstName, string lastName, string phone, string email, string address) : base( identity, firstName, lastName, phone, email, address)
        {
        }
    }
}