using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace schoolreport.Controllers.Resources
{
    public class SaveZoneResources
    {
        public SaveZoneResources()
        {
            Schools = new Collection<int>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public int DistrictId { get; set; }

        public DistrictResources District { get; set; }

        public virtual ICollection<int> Schools { get; set; }
    }
}