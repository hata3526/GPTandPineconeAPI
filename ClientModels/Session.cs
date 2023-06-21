using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientModels
{
    public class Session : BaseClass
    {
        public long FKUser { get; set; }
        [ForeignKey(nameof(FKUser))]
        public User User { get; set; }

        public long FKBotCharacter { get; set; }
        [ForeignKey(nameof(FKBotCharacter))]
        public BotCharacter BotCharacter { get; set; }

        public DateTime StartedOn  { get; set; }
        public DateTime? EndedOn { get; set; }
        public ICollection<Message> Messages { get; set; }
    }
}
