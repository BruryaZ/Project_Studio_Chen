using Microsoft.AspNetCore.Mvc;
using Studio_Chen.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Studio_Chen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        static List<Course> _allCourses = new List<Course>() { 
            new Course() { EndDate = new DateTime(), StartDate = new DateTime(), 
                MeetsNumber = 1, Equipment = new List<string>() { "Water" }, Type = ETypeOfCourse.ballet } ,
            new Course() { EndDate = new DateTime(), StartDate = new DateTime(),
                MeetsNumber = 1, Equipment = new List<string>() { "Water" }, Type = ETypeOfCourse.pilates } };
        // GET: api/<GymnastController>
        [HttpGet]
        public IEnumerable<Course> Get()
        {
            return _allCourses;
        }

        // GET api/<GymnastController>/5
        [HttpGet("{id}")]
        public ActionResult Get(string id)
        {
            var course = _allCourses.Find(x => x.Identity == id);
            if (course == null)
                return NotFound();
            return Ok(course);
        }

        // POST api/<GymnastController>
        [HttpPost]
        public void Post([FromBody] Course value)
        {
            _allCourses.Add(value);
        }

        // PUT api/<GymnastController>/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Course value)
        {
            for (int i = 0; i < _allCourses.Count; i++)
            {
                if (_allCourses[i].Identity == id)
                {
                    _allCourses[i].MeetsNumber = value.MeetsNumber;
                    _allCourses[i].EndDate = value.EndDate;
                    _allCourses[i].StartDate = value.StartDate;
                    _allCourses[i].Type = value.Type;
                    _allCourses[i].Equipment = value.Equipment;
                }
            }
        }

        // DELETE api/<GymnastController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            for (int i = 0; i < _allCourses.Count; i++)
            {
                if (_allCourses[i].Identity == id)
                    _allCourses.Remove(_allCourses[i]);
            }
        }
    }
}
