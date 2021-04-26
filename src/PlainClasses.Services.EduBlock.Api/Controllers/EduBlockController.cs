using Microsoft.AspNetCore.Mvc;

namespace PlainClasses.Services.EduBlock.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EduBlockController : ControllerBase
    {
        public EduBlockController() { }

        [HttpGet]
        public string Get() => "EduBlock Service";
    }
}