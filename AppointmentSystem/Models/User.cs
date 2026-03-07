namespace AppointmentSystem.Models
{
    public class User
    {
        public int Id { get; set; }

        public string fullName {  get; set; }=string.Empty;

        public string email { get; set; } = string.Empty;

        public string PasswordHash { get; set; }= string.Empty;
        public string phone {  get; set; } = string.Empty;

        public int roleId { get; set; }

        public string address {  get; set; } = string.Empty;


        public Doctor? Doctor { get; set; }
    }
}
