using System.ComponentModel.DataAnnotations;

namespace KubeTestAPI.Entities
{
    public class Temperatures
    {
        [Key]
        public string LocationID { get; set; }
        public DateOnly Timestamp { get; set; }
        public decimal Temperature { get; set; }

    }
}
