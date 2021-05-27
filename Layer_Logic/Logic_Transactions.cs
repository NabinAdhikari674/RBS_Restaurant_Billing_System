using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBS_Restaurant_Billing_System.Layer_Logic
{
    class Logic_Transactions
    {
        public int Id { get; set; }
        public String Cashier { get; set; }
        public int Amount { get; set; }
        public String Items { get; set; }
        public DateTime Date { get; set; }

    }
}
