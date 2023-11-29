using Maccabi4u.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Numerics;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Maccabi4u.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        //static List<Patient> patients = new List<Patient>();
        private readonly DataContext _context;

        public PatientController(DataContext context)
        {
            _context = context;
        }
        // GET: api/<PatientController>
        [HttpGet]
        public IEnumerable<Patient> Get()
        {
            return _context.PatientList;
        }

        // GET api/<PatientController>/5
        [HttpGet("{id}")]
        public Patient Get(int id)
        {
            return _context.PatientList.Find(p=>p.IdNumber==id);
        }

        // POST api/<PatientController>
        [HttpPost]
        public void Post([FromBody] Patient patient)
        {
            _context.PatientList.Add(patient);
        }

        // PUT api/<PatientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Patient patient)
        {
            Patient pat = _context.PatientList.Find(p => p.IdNumber == id);
            if (pat != null)
            {
                pat.Name = patient.Name;
                pat.DateBorn = patient.DateBorn; 
                pat.Address = patient.Address;
                pat.PhoneNumber = patient.PhoneNumber;
              
            }
        }

        // PUT api/<PatientController>/5
        [HttpPut("{id}/{status}")]
        public void Put(bool status,int id, [FromBody] Patient patient)
        {
            Patient pat = _context.PatientList.Find(p => p.IdNumber == id);
            if (pat != null)
                pat.Status =patient.Status;
  
        }

        // DELETE api/<PatientController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
