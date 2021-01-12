using System;
using System.Collections.Generic;
using System.Text;

namespace BDGA3.Models
{
    public class ChannelFollow
    {
        public int id { get; set; }
        public int channel_id { get; set; }
        public int follow_id { get; set; }

        public Channel channel { get; set; }
        public Channel follow { get; set; }
    }
}
