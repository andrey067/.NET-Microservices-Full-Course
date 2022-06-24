using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace CommandService.Controllers
{
    [Route("api/c/[controller]")]
    [ApiController]
    public class PlatformsController : ControllerBase
    {
        private readonly IMapper _mapper;

        public PlatformsController(IMapper mapper)
        {
            _mapper = mapper;
        }


        [HttpPost]
        public ActionResult TestInboundConnection()
        {
            Console.WriteLine("--> Inbound POST # Command Service");

            return Ok("Inbound test of from Platforms Controler");
        }
        // [HttpGet]
        // public ActionResult<IEnumerable<PlatformreadDto>> GetPlatforms()
        // {
        //     Console.WriteLine("--> Getting Platforms from CommandsService");

        //     var platformItems = _repository.GetAllPlatforms();

        //     return Ok(_mapper.Map<IEnumerable<PlatformreadDto>>(platformItems));
        // }
    }
}