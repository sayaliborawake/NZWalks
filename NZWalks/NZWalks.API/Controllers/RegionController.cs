using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Models.Domain;
using NZWalks.API.Repositories;

namespace NZWalks.API.Controllers
{
    [ApiController]
    [Route("Regions")]
    public class RegionController : Controller
    {
        private readonly IMapper mapper;
        private readonly IRegionRepository regionRepository;

        public RegionController(IRegionRepository regionRepository, IMapper mapper)
        {
            this.regionRepository = regionRepository;
            this.mapper = mapper;
        }


        [HttpGet]
        public IActionResult GetAllRegions() 
        {
            var regions = regionRepository.GetAllAsync();

            // Return DTO regions
            //var RegionsDTO = new List<Models.DTO.Region>();
            //regions.ToList().ForEach(region =>
            //{
            //    var regionDTO = new Models.DTO.Region()
            //    {
            //        Id= region.Id,
            //        Name = region.Name,    
            //        Area= region.Area,
            //        Lat = region.Lat,
            //        Long = region.Long,
            //        Population= region.Population
            //    };
            //});
            var RegionsDTO =  mapper.Map<List<Models.DTO.Region>>(regions);

            return Ok(RegionsDTO);
        }
    }
}
