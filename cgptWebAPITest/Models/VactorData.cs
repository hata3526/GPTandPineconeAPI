using System.ComponentModel.DataAnnotations;

namespace cgptWebAPITest.Models
{
    public class VactorData
    {

        public required string id { get; set; }
      
        public required float[] Values { get; set; }
    }
}
