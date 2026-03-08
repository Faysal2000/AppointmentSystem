using System.ComponentModel.DataAnnotations.Schema;

namespace AppointmentSystem.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        public int DoctorServiceId { get; set; }

        public int PatientId { get; set; }

        public DateTime AppointmentDate { get; set; }

        public string Status { get; set; } = string.Empty;

        public string Notes { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DoctorService DoctorService { get; set; }

        public Patient Patient { get; set; }

        public Invoice Invoice { get; set; }
    }
}
