using AutoMapper;
using schoolreport.Controllers.Resources;
using schoolreport.HelperFolder;
using schoolreport.Models;

namespace schoolreport.Mapping
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            //Domain to API
            CreateMap<Zone, SaveZoneResources>()
            .ForMember(zr => zr.District, opt => opt.MapFrom(z => new DistrictResources { Id = z.District.Id, Name = z.District.Name }));
            CreateMap<District,DistrictResources>();
            CreateMap<School, SaveSchoolResources>();
            CreateMap<School, SchoolResources>()
                .ForMember(s => s.Zone, opt => opt.MapFrom(sr => new ZoneResources { Name = sr.Zone.Name , Id = sr.Zone.Id }))
                .ForMember(dis => dis.District, opt => opt.MapFrom(di => new DistrictResources { Id = di.Zone.District.Id, Name = di.Zone.District.Name }))
                .ForMember(st => st.SchoolType, opt => opt.ResolveUsing( sts => MapSchool(sts.SchoolType.ToString())));
                


            //Api to domain
            CreateMap<SaveSchoolResources,School>();

        }

        public static SchoolType MapSchool(string school)
        {
            //TODO: function to map a string to a SchoolGradeDTO
            return EnumHelper<SchoolType>.Parse(school);
        }
    }
}