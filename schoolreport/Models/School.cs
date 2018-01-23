using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace schoolreport.Models
{
    [Table("Schools")]
    public class School
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string PrincipalName { get; set; }

        public SchoolType SchoolType { get; set; }

        public int ZoneId { get; set; }

        public Zone Zone { get; set; }
    }
}