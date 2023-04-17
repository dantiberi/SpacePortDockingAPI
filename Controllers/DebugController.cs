using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpacePortDockingAPI.Objects;

namespace SpacePortDockingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DebugController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> TestJSON()
        {
            return Content(JSONHandler.LoadOptionsJson().database.dbFileName, "text/plain");
        }
    }
}
