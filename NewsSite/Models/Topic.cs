using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsSite.Models
{
    public class Topic
    {
        public int TopicId { get; set; }
        public string NameOfTopic { get; set; }
        public string TopicBody { get; set; }

        public Topic()
        {

        }
    }
}
