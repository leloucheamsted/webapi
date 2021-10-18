using AutoMapper;
using Entities.DataTransfertObject;
using Entities.Models;

namespace webapi
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Mapping Company
            CreateMap<Company, CompanyDto>()
            .ForMember(c => c.FullAddress,
            opt => opt.MapFrom(x => string.Join(' ', x.Address, x.Country)));

            // Mapping Employees
            CreateMap<Employee, EmployeeDto>();
        }
    }

}
