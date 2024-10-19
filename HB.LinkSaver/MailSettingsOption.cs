using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HB.LinkSaver
{
    public class MailSettingsOption
    {
        public int PortNumber { get; set; }
        public string MailAddress { get; set; }
        public string StmpServer { get; set; }
        public string AppPassword { get; set; }
        public string RecipientMailAddress { get; set; }
    }
}
