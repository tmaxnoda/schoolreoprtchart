namespace schoolreport.Controllers.Resources
{
    public class SchoolResources
    {
       public SchoolResources()
        {
           
        }
        public int Id { get; set; }
       
        public string Name { get; set; }
       
        public string Address { get; set; }
        
        public string Email { get; set; }
       
        public string PrincipalName { get; set; }
        
        public string SchoolType { get; set; }
        
       
        public ZoneResources Zone { get; set; }

        public DistrictResources District { get; set; } 
    }
}