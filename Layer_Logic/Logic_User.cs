using System;

namespace RBS_Restaurant_Billing_System.Layer_Logic
{
    class Logic_User
    {
        public int Id { get; set; }
        public String Username { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public String Role { get; set; }
        public int Phone { get; set; }
        public String Address { get; set; }
        public DateTime AddedOn { get; set; }
    }
}
