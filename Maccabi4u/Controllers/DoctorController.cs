using Maccabi4u.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Maccabi4u.Controllers
{
 
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        //static List<Doctor> doctors = new List<Doctor>();

        private readonly DataContext _context;
        private static int count = 0;

        public DoctorController(DataContext context)
        {
            _context = context;
        }


        // GET: api/<DoctorController>
        [HttpGet]
        public IEnumerable<Doctor> Get()
        {
            return _context.DoctorList;
        }

        // GET api/<DoctorController>/5
        [HttpGet("{id}")]
        public Doctor Get(int id)
        {
            return _context.DoctorList.Find(d => d.Id == id);
        }

        // POST api/<DoctorController>
        [HttpPost]
        public void Post([FromBody] Doctor doctor)
        {
            _context.DoctorList.Add(doctor);
        }

        // PUT api/<DoctorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Doctor doctor)
        {
            Doctor doc = _context.DoctorList.Find(p => p.Id == id);
            if (doc != null)
            {
                doc.Name = doctor.Name;
                doc.DateBorn = doctor.DateBorn;
                doc.Address = doctor.Address;
                doc.PhoneNumber = doctor.PhoneNumber;

            }
        }
        // PUT api/<DoctorController>/5/status

        [HttpPut("{id}/{status}")]
        public void Put(bool status, int id, [FromBody] Doctor doctor)
        {
            Doctor doc = _context.DoctorList.Find(p => p.Id == id);
            if (doc != null)
                doc.Status = doctor.Status;
        }
        //// DELETE api/<DoctorController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
