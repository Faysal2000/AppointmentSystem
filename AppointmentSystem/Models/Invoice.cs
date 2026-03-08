namespace AppointmentSystem.Models
{
    public class Invoice
    {
        public int Id { get; set; } 

        public int PatientId {  get; set; }

        public int AppointmentId {  get; set; }

        public decimal TotalAmount {  get; set; }

        public string Status { get; set; }=string.Empty;

        public DateTime IssuedDate { get; set; }

        public DateTime PaidDate { get; set; }
    }
}
