using System.ComponentModel.DataAnnotations.Schema;

namespace AppointmentSystem.Models
{
    public class Appointment
    {
        public int Id { get; set; } 
        public int doctorId { get; set; }
        public int patientId {  get; set; }
        public int serviceId {  get; set; }

        public int doctorServiceId { get; set; }
        public DateTime appointmentDate { get; set; }   
        public string status { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty ;

       
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;



        public int DoctorId { get; set; }
        public Doctor? Doctor { get; set; }

        public int PatientId { get; set; }
        public Patient? Patient { get; set; }
        public DoctorService? DoctorService { get; set; }
        public Invoice? Invoice { get; set; }


        public int ServiceId { get; set; }
        public Service? Service { get; set; }
    }
}
