using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientModels
{
    public class User : BaseClass
    {
        public string Name { get; set; }
        public ICollection<Session> Sessions { get; set; }

       
    }
}
