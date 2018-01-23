using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace schoolreport.Models
{
     [Table("Districts")]
    public class District
    {
        public District()
        {
            Zones = new Collection<Zone>();
        }
        public int Id { get; set; }


        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public ICollection<Zone> Zones { get; set; }
    }
}