namespace Studio_Chen.Entities
{
    public class Lesson
    {
        static int count = 1;
        public string Identity { get; private set; }
        public string CourseIdentity { get; set; }
        public int MeetNumber { get; set; }
        public DateTime Date { get; set; }
        public TimeOnly StartHour { get; set; }
        public TimeOnly EndHour { get; set; }
        public Teacher Teacher { get; set; }
        public List<string> EquipmentList { get; set; }
        public List<Gymnast> GymnastList { get; set; }
        public Lesson( string courseIdentity, int meetNumber, DateTime date, TimeOnly startHour, TimeOnly endHour, Teacher teacher, List<string> equipmentList, List<Gymnast> gymnastList)
        {
            Identity = (count++).ToString();
            CourseIdentity = courseIdentity;
            MeetNumber = meetNumber;
            Date = date;
            StartHour = startHour;
            EndHour = endHour;
            Teacher = teacher;
            EquipmentList = equipmentList;
            GymnastList = gymnastList;
        }
        public Lesson()
        {
            Identity = (count++).ToString();
        }
    }
}