using System;
using System.Collections.Generic;
using System.Text;

namespace BDGA3.Models
{
    public class Email
    {
        public int id { get; set; }
        public string address { get; set; }
        public DateTime reg_date { get; set; }
        public string phone_num { get; set; }
    }
}
