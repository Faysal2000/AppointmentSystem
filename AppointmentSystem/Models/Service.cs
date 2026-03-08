namespace AppointmentSystem.Models
{
    public class Service
    {
        

        public int Id { get; set; }

        public string ServiceName { get; set; } = string.Empty;

        public string Description { get; set; }= string.Empty;  
        public int DurationInMinutes { get; set; }


        public ICollection<DoctorService>? DoctorServices { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();


    }
}
