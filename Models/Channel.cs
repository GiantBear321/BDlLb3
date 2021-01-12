using System;
using System.Collections.Generic;
using System.Text;

namespace BDGA3.Models
{
    public class Channel
    {
        public int id { get; set; }
        public string name { get; set; }
        public int email_id { get; set; }
        public Email email { get; set; }

    }
}
