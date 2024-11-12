using ClassLibraries;

namespace Studio_Chen.Entities
{
    public class Teacher : Person
    {
        public List<Course> courses { get; set; }

        public Teacher(List<Course> courses, string identity, string firstName, string lastName, string phone, string email, string address) 
            : base(identity, firstName, lastName, phone, email, address)
        {
            this.courses = courses;
        }

        public Teacher()
        {
        }
    }
}