using Microsoft.AspNetCore.Mvc;
using Studio_Chen.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Studio_Chen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        int count = 1;
        static List<Course> courseList = new List<Course>() { new Course() { EndDate = new DateTime(), StartDate = new DateTime(), MeetsNumber = 1, Equipment = new List<string>() { "Water" }, Type = ETypeOfCourse.ballet } };
        private static List<Teacher> _allTeachers = new List<Teacher>() { new Teacher() { courses = courseList, LastName = "Levi", Address = "Jerusalem", Email = "13@gmail", FirstName = "Nechama", Identity = "3", Phone = "03" },
                                                    new Teacher() { courses = courseList, LastName = "Lederman", Address = "Emanuhel", Email = "14@gmail", FirstName = "Galit", Identity = "4", Phone = "09" } };
        // GET: api/<TeacherController>
        [HttpGet]
        public IEnumerable<Teacher> Get()
        {
            return _allTeachers;
        }

        // GET api/<TeacherController>/5
        [HttpGet("{id}")]
        public ActionResult Get(string id)
        {
            var teacher = _allTeachers.Find(x => x.Id == id);
            if (teacher == null)
                return NotFound();
            return Ok(teacher);
        }

        // POST api/<TeacherController>
        [HttpPost]
        public void Post([FromBody] Teacher value)
        {
            _allTeachers.Add(value);
        }

        // PUT api/<TeacherController>/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Teacher value)
        {
            for (int i = 0; i < _allTeachers.Count; i++)
            {
                if (_allTeachers[i].Identity == id)
                {
                    _allTeachers[i].Identity = value.Identity;
                    _allTeachers[i].Address = value.Address;
                    _allTeachers[i].FirstName = value.FirstName;
                    _allTeachers[i].LastName = value.LastName;
                    _allTeachers[i].Email = value.Email;
                    _allTeachers[i].Phone = value.Phone;
                    _allTeachers[i].courses = value.courses;
                }
            }
        }

        // DELETE api/<TeacherController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            for (int i = 0; i < _allTeachers.Count; i++)
            {
                if (_allTeachers[i].Identity == id)
                    _allTeachers.Remove(_allTeachers[i]);
            }
        }
    }
}