using System.ComponentModel.DataAnnotations;

namespace schoolreport.Controllers.Resources
{
    public class SaveSchoolResources
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PrincipalName { get; set; }
        [Required]
        public byte SchoolType { get; set; }
        [Required]
        public int ZoneId { get; set; }

        //public Zone Zone { get; set; }
    }
}