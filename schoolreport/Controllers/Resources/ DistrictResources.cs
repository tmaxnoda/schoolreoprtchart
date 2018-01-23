using System.ComponentModel.DataAnnotations;

namespace schoolreport.Controllers.Resources
{
    public class  DistrictResources
    {
        public DistrictResources()
        {
            // Zones = new Collection<ZoneResources>();
        }
        public int Id { get; set; }


        [Required]
        public string Name { get; set; }
    }
}