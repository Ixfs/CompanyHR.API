using AutoMapper;
using CompanyHR.API.DTOs;
using CompanyHR.API.Models;

namespace CompanyHR.API.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Employee, EmployeeDto>().ReverseMap();
        CreateMap<Position, PositionDto>().ReverseMap();
        CreateMap<Department, DepartmentDto>().ReverseMap();
        // Другие маппинги
    }
}