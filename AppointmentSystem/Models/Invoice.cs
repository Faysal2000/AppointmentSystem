namespace AppointmentSystem.Models
{
    public class Invoice
    {
        public int Id { get; set; } 

        public int patientId {  get; set; }

        public int appointmentId {  get; set; }

        public decimal totalAmount {  get; set; }

        public string status { get; set; }=string.Empty;

        public DateTime issuedDate { get; set; }

        public DateTime paidDate { get; set; }
    }
}
