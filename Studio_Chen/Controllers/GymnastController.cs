using Microsoft.AspNetCore.Mvc;
using Studio_Chen.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Studio_Chen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GymnastController : ControllerBase
    {
        static List<Gymnast> _allGymnast = new List<Gymnast>() {
            new Gymnast() { Address = "BB", Email = "@gmail", FirstName = "Shosh", LastName = "Telem", Phone = "03", Identity = "2" },
            new Gymnast() { Address = "Emanuhel", Email = "@gmail", FirstName = "Ester", LastName = "Zarniv", Phone = "09", Identity = "3"}};

        // GET: api/<GymnastController>
        [HttpGet]
        public IEnumerable<Gymnast> Get()
        {
            return _allGymnast;
        }

        // GET api/<GymnastController>/5
        [HttpGet("{id}")]
        public ActionResult Get(string id)
        {
            var gymnast = _allGymnast.Find(x => x.Identity == id);
            if (gymnast == null)
                return NotFound();
            return Ok(gymnast);
        }

        // POST api/<GymnastController>
        [HttpPost]
        public void Post([FromBody] Gymnast value)
        {
           _allGymnast.Add(value);
        }

        // PUT api/<GymnastController>/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Gymnast value)
        {
            for (int i = 0; i < _allGymnast.Count; i++)
            {
                if (_allGymnast[i].Identity == id)
                {
                    _allGymnast[i].Address = value.Address;
                    _allGymnast[i].Phone = value.Phone;
                    _allGymnast[i].Identity = value.Identity;
                    _allGymnast[i].FirstName = value.FirstName;
                    _allGymnast[i].LastName = value.LastName;
                    _allGymnast[i].Email = value.Email;
                }
            }
        }

        // DELETE api/<GymnastController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            for (int i = 0; i < _allGymnast.Count; i++)
            {
                if (_allGymnast[i].Identity == id)
                    _allGymnast.Remove(_allGymnast[i]);
            }
        }
    }
}
