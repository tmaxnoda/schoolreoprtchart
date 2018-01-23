using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace schoolreport.Models
{
     [Table("Zones")]
    public class Zone
    {
         public Zone() => Schools = new Collection<School>();
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public int DistrictId { get; set; }

        [ForeignKey("DistrictId")]
        public District District { get; set; }

        public virtual ICollection<School> Schools { get; set; }
    }
}