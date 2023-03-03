using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    public class Note
    {
        public string Content { get;  }
        public string Topic { get; }
        public Note(string content, string topic)
        {
            Content = content;
            Topic = topic;
        }
    }
}
