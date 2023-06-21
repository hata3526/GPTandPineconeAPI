using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientModels
{
    public class Message : BaseClass
    {
       
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }

        public  MessageType MessageType { get; set; }

        public long FKSession { get; set; }
        [ForeignKey(nameof(FKSession))]
        public Session Session { get; set; }
    }
}
