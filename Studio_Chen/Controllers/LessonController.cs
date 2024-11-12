using Microsoft.AspNetCore.Mvc;
using Studio_Chen.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Studio_Chen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonController : ControllerBase
    {
        static List<Course> courseList = new List<Course>() { new Course() { EndDate = new DateTime(), StartDate = new DateTime(), MeetsNumber = 1, Equipment = new List<string>() { "Water" }, Type = ETypeOfCourse.ballet } };
        static List<Gymnast> gymnastsList = new List<Gymnast>() { new Gymnast() { Address = "BB", Email = "@gmail", FirstName = "Shosh", LastName = "Telem", Phone = "03", Identity = "2" } };
        static List<Lesson> _allLesson = new List<Lesson>() {
                            new Lesson() { StartHour = new TimeOnly(), CourseIdentity = "1", Date = new DateTime(),
                            EndHour = new TimeOnly(),  MeetNumber = 1, GymnastList = gymnastsList ,
                            EquipmentList=new List<string>(){ "water", "gym shorts"},Teacher= new Teacher()
                            { courses = courseList, LastName = "Levi", Address = "Jerusalem", Email = "13@gmail", FirstName =
                            "Nechama", Identity = "3", Phone = "03" } } };

        // GET: api/<LessonController>
        [HttpGet]
        public IEnumerable<Lesson> Get()
        {
            return _allLesson;
        }

        // GET api/<LessonController>/5
        [HttpGet("{id}")]
        public ActionResult Get(string id)
        {
            var lesson = _allLesson.Find(x => x.Identity == id);
            if (lesson == null)
                return NotFound();
            return Ok(lesson);
        }

        // POST api/<LessonController>
        [HttpPost]
        public void Post([FromBody] Lesson value)
        {
            _allLesson.Add(value);
        }

        // PUT api/<LessonController>/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Lesson value)
        {
            for (int i = 0; i < _allLesson.Count; i++)
            {
                if (_allLesson[i].Identity == id)
                {
                    _allLesson[i].CourseIdentity = value.Identity;
                    _allLesson[i].MeetNumber = value.MeetNumber;
                    _allLesson[i].EndHour = value.EndHour;
                    _allLesson[i].EquipmentList = value.EquipmentList;
                    _allLesson[i].Date = value.Date;
                    _allLesson[i].StartHour = value.StartHour;
                    _allLesson[i].Teacher = value.Teacher; 
                    _allLesson[i].GymnastList = value.GymnastList;
                }
            }
        }

        // DELETE api/<LessonController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            for (int i = 0; i < _allLesson.Count; i++)
            {
                if (_allLesson[i].Identity == id)
                    _allLesson.Remove(_allLesson[i]);
            }
        }
    }
}
