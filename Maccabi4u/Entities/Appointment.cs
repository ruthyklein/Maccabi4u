namespace Maccabi4u.Entities
{
    public class Appointment
    {
        static int count = 0;
        public int Id { get;  }
        public DateTime DateTime { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }

        public Appointment(DateTime dateTime, Doctor doctor, Patient patient)
        {
            Id = ++count;
            DateTime = dateTime;
            Doctor = doctor;
            Patient = patient;
        }

        Appointment()
        {
            Id = ++count;
        }

    }
}
