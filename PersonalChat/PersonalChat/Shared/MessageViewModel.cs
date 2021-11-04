using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalChat.Shared
{
    public class MessageViewModel
    {
        public string FromUserId { get; set; }
        public string ToUserId { get; set; }

        public string Message { get; set; }

    }
}
