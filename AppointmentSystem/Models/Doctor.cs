namespace AppointmentSystem.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public int userId { get; set; }
        public string specialization {  get; set; } = string.Empty;

        public int experienceYears {  get; set; }


        public ICollection<DoctorService>? DoctorServices { get; set; }
        public ICollection<DoctorSchedule>? DoctorSchedules { get; set; }
        public ICollection<Appointment>? Appointments { get; set; }
        public ICollection<DoctorSpecialty>? DoctorSpecialty { get; set; }


    }
}
