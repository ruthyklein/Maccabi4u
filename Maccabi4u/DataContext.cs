using CsvHelper;
using Maccabi4u.Entities;
using Microsoft.Extensions.Logging;
using System.Formats.Asn1;
using System.Globalization;

namespace Maccabi4u
{
    public class DataContext
    {
        public List<Appointment> AppointmentsList { get; set; }
        public List<Doctor> DoctorList { get; set; }
        public List<Patient> PatientList { get; set; }

        public DataContext()
        {
            using (var reader = new StreamReader("data.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                AppointmentsList = csv.GetRecords<Appointment>().ToList();
                DoctorList = csv.GetRecords<Doctor>().ToList();
                PatientList = csv.GetRecords<Patient>().ToList();
            }

        }
    }
}
