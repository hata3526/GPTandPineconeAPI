using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientModels
{
    public enum MessageType
    {
        [Display(Name = "User")]
        User,
        [Display(Name = "Bot")] 
        Bot
    }
}
