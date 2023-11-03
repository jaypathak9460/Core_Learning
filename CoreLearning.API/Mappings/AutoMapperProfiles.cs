using AutoMapper;
using CoreLearning.API.Model.Domain;
using CoreLearning.API.Model.DTO;

namespace CoreLearning.API.Mappings
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Region, RegionDto>().ReverseMap();
            CreateMap<Region, UpdateRegionRequest>().ReverseMap();
            CreateMap<Region, addRegionRequestDto>().ReverseMap();
            CreateMap<Walk, AddWalksRequestDto>().ReverseMap();
            CreateMap<Walk, WalkDto>().ReverseMap();
            CreateMap<Walk, UpdateWalksRequestDto>().ReverseMap();
            CreateMap<Difficulty, DifficultyDto>().ReverseMap();
        }
    }
} 
