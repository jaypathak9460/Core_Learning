using AutoMapper;
using CoreLearning.API.CustomActionFilter;
using CoreLearning.API.Model.Domain;
using CoreLearning.API.Model.DTO;
using CoreLearning.API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreLearning.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalksController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IWalksRepository repository;

        public WalksController(IMapper mapper, IWalksRepository repository)
        {
            this.mapper = mapper;
            this.repository = repository;
        }
        //create Walk  post method
        [HttpPost]
        [ValidateModel]
        public async Task<IActionResult> Create([FromBody] AddWalksRequestDto addWalksRequestDto)
        {

            
            //map dto to Domain model
            var domianModel = mapper.Map<Walk>(addWalksRequestDto);

            domianModel = await repository.CreateAsync(domianModel);

            //convert domain Model to DTO

            return Ok(mapper.Map<WalkDto>(domianModel));
        }
        // get all the walks
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var walks = await repository.GetAllAsync();
            return Ok(mapper.Map<List<WalkDto>>(walks));
        }

        //get walk by id
        [HttpGet]
        [Route("{Id:Guid}")]
        public async Task<IActionResult> GetDetailsById([FromRoute] Guid Id) {
            var walkDomainModel = await repository.GetByIdAsync(Id);
            if (walkDomainModel == null) {
                return NotFound();

            }
            return Ok(mapper.Map<WalkDto>(walkDomainModel));
        }
        //update walk by Id
        [HttpPut]
        [Route("{Id:Guid}")]
        public async Task<IActionResult> update([FromRoute] Guid Id,[FromBody] UpdateWalksRequestDto dto)
        {
            if (!ModelState.IsValid) //   [ValidateModel] both are the same 
            {
                return BadRequest(ModelState);
            }

            var walkDomainModel = await repository.UpdateAsync(Id,mapper.Map<Walk>(dto)); 
            if (walkDomainModel == null)
            {
                return NotFound();

            }
            return Ok(mapper.Map<WalkDto>(walkDomainModel));
        }
        // delete walk by id
        [HttpDelete]
        [Route("{Id:Guid}")]
        public async Task<IActionResult> delete([FromRoute] Guid Id)
        {
            var deletedWalks = await repository.DeleteAsync(Id);
            if (deletedWalks == null)
            {
                return NotFound();

            }
            return Ok(mapper.Map<WalkDto>(deletedWalks));
        }
    }
}
