using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace KubeTestAPI.Entities
{
    public class Locations
    {
        [Key]
        public string LocationId { get; set; }
        public string LocationName { get; set; }
    }
}
