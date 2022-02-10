using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisenessObjects.Models
{
    public class MailDto
    {
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Recipients { get; set; }
    }
}
