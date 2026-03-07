namespace AppointmentSystem.Models
{
    public class DoctorSchedule
    {
        public int Id { get; set; } 

        public int doctorId {  get; set; }

        public int dayOfWeek { get; set; }
            
        public DateTime startTime {  get; set; }

        public DateTime endTime { get; set; }

        public Doctor? Doctor { get; set; }

    }
}
