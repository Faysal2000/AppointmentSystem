namespace AppointmentSystem.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Specialization {  get; set; } = string.Empty;

        public int ExperienceYears {  get; set; }


        public ICollection<DoctorService>? DoctorServices { get; set; }
        public ICollection<DoctorSchedule>? DoctorSchedules { get; set; }
        public ICollection<Appointment>? Appointments { get; set; }
        public ICollection<DoctorSpecialty>? DoctorSpecialty { get; set; }


    }
}
