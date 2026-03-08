namespace AppointmentSystem.Models
{
    public class DoctorService
    {
        public int Id { get; set; } 

        public int DoctorId {  get; set; }

        public int ServiceId {  get; set; }

        public int DurationInMints { get; set; }

        public decimal Price {  get; set; }

        public ICollection<Appointment>? Appointments { get; set; }


    }
}
