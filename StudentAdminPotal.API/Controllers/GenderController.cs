using Microsoft.AspNetCore.Mvc;
using StudentAdminPotal.API.DomainModel;

namespace StudentAdminPotal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenderController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetAllGender()
        {
            List<Gender> genderList = new()
            {
                new Gender{Id=Guid.NewGuid(), Description= "Male"},
                new Gender{Id=Guid.NewGuid(), Description="Female"},
            };
            return Ok(genderList);
        }
    }
}
