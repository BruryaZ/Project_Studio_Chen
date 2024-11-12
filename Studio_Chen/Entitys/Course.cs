namespace Studio_Chen.Entities
{
    public enum ETypeOfCourse { pilates, design_and_toning, Aerobics_band_dynamic_design, floor_exercise, ballet, dance }
    public class Course
    {
        static int count = 1;
        public string Identity { get; private set; }
        public int MeetsNumber { get; set; }
        public ETypeOfCourse Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        //public Teacher Teacher { get; set; }
        public List<string> Equipment { get; set; }
        List<Lesson> lessons { get; set; }

        public Course( int meetsNumber, ETypeOfCourse type, DateTime startDate, DateTime endDate, List<string> equipment, List<Lesson> lessons)
        {
            Identity = (count++).ToString();
            MeetsNumber = meetsNumber;
            Type = type;
            StartDate = startDate;
            EndDate = endDate;
            Equipment = equipment;
            this.lessons = lessons;
        }

        public Course()
        {
            Identity = (count++).ToString();
        }
    }
}
