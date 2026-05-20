using ASP.NETCoreAPI.Models;
using AutoMapper;

namespace ASP.NETCoreAPI.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            // Mapeamento entre as classes de modelo e os DTOs
            CreateMap<UpdateBooksDto, Books>()
                .ForAllMembers(opts => opts.Condition(
                    (src, dest, srcMember) => srcMember != null
                ));
        }
    }
}
