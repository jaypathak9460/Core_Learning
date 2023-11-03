
using AutoMapper;
using CoreLearning.API.Data;
using CoreLearning.API.Model.Domain;
using CoreLearning.API.Model.DTO;
using CoreLearning.API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoreLearning.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly IRegionRepository regionRepository;
        private readonly IMapper mapper;

        public RegionsController(IMapper mappear, IRegionRepository regionRepository)
        {
            this.regionRepository = regionRepository;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var regions = await regionRepository.GetAllAsync();
            // Convert domain model to DTOs
            var regionsDto = mapper.Map<List<RegionDto>>(regions);
            //returns Convert DTOs to clinets
            return Ok(regionsDto);
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetDetailById([FromRoute] Guid id)
        {
            var region = await regionRepository.GetDetailsByIdAsync(id);
            if (region == null)
            {
                return NotFound();
            }
            var regionDTO = mapper.Map<RegionDto>(region);
           
            return Ok(regionDTO);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] addRegionRequestDto dto)
        {

            // Convert DTo To Domain model
            var domainModel = mapper.Map<Region>(dto);
            domainModel = await regionRepository.CreateAsync(domainModel);
            //Convert domain model to DTO
            var returndto = mapper.Map<RegionDto>(domainModel);

            return CreatedAtAction(nameof(GetDetailById), new { id = domainModel.Id }, returndto);
        }

        //update Region
        [HttpPut]
        [Route("{Id:Guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid Id, [FromBody] UpdateRegionRequest updateDto)
        {
            //Convert DTo to Domain Model
            var regionDomainModel = mapper.Map<Region>(updateDto);

            regionDomainModel = await regionRepository.UpdateAsync(Id, regionDomainModel);
            if (regionDomainModel == null)
            {
                return NotFound();
            }
            // Convert domain model to DTO

            var regionDTO = mapper.Map<RegionDto>(regionDomainModel);
            return Ok(regionDTO);
        }
        [HttpDelete]
        [Route("{Id:Guid}")]
        public async Task<IActionResult> delete([FromRoute] Guid Id)
        {
            var region = await regionRepository.DeleteAsync(Id);
            if (region == null)
            {
                return NotFound();
            }

            // Convert domain model to DTO
            var regionDTO = mapper.Map<RegionDto>(region);
           
            return Ok(regionDTO);
        }

    }
}

