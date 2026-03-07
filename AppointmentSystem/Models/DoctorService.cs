namespace AppointmentSystem.Models
{
    public class DoctorService
    {
        public int Id { get; set; } 

        public int doctorId {  get; set; }

        public int serviceId {  get; set; }

        public int durationInMints { get; set; }

        public decimal price {  get; set; }

        public ICollection<Appointment>? Appointments { get; set; }


    }
}
