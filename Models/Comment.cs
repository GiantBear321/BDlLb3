using System;
using System.Collections.Generic;
using System.Text;

namespace BDGA3.Models
{
    public class Comment
    {
        public int id { get; set; }
        public int creator_id { get; set; }
        public int video_id { get; set; }
        public Channel creator { get; set; }
        public Video video { get; set; }

        public string text { get; set; }

    }
}
