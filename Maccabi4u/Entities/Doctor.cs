namespace Maccabi4u.Entities
{
    public class Doctor
    {
        static int count = 0;

        public int Id { get;  }
        public string Name { get; set; }
        public DateTime DateBorn { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool Status { get; set; }

        public Doctor(string name, DateTime dateBorn, string address, string phoneNumber)
        {
            Id = ++count;
            Name = name;
            DateBorn = dateBorn;
            Address = address;
            PhoneNumber = phoneNumber;
        }


        Doctor()
        {
            Id = ++count;
        }
    }
}
