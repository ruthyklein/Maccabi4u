using Maccabi4u.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Numerics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Maccabi4u.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        //static List<Appointment> appointments = new List<Appointment>();

        private readonly DataContext _context;
        private static int count = 0;

        public AppointmentController(DataContext context)
        {
            _context = context;
        }

        // GET: api/<AppointmentController>
        [HttpGet]
        public IEnumerable<Appointment> Get()
        {
            return _context.AppointmentsList;
        }

        // GET api/<AppointmentController>/5
        [HttpGet("{id}")]
        public Appointment Get(int id)
        {
            return _context.AppointmentsList.Find(a=>a.Id==id);
        }

        // POST api/<AppointmentController>
        [HttpPost]
        public void Post([FromBody] Appointment appointment)
        {
            _context.AppointmentsList.Add(appointment);

           // appointments.Add(new Appointment { Id = appointment.Id, DateTime = appointment.DateTime, Doctor = appointment.Doctor, Patient = appointment.Patient});

        }

        // PUT api/<AppointmentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Appointment appointment)
        {
            Appointment app = _context.AppointmentsList.Find(a => a.Id == id);
            if (app != null)
            {
                app.DateTime = appointment.DateTime;
                app.Doctor = appointment.Doctor;
                app.Patient = appointment.Patient;

            }
        }

        // DELETE api/<AppointmentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Appointment app = _context.AppointmentsList.Find(a => a.Id == id);
            _context.AppointmentsList.Remove(app);
        }
    }
}
