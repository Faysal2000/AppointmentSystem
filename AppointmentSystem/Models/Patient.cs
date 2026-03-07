namespace AppointmentSystem.Models
{
    public class Patient
    {
        public int Id { get; set; }

        public string fullName {  get; set; } =string.Empty;    

        public DateOnly dateOfBirth {  get; set; }

        public string gender { get; set; }  = string.Empty;

        public string phone {  get; set; }=string.Empty;



        public ICollection<Appointment>? Appointments { get; set; }



    }
}
