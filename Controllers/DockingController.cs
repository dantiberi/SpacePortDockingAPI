using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpacePortDockingAPI.Objects;

namespace SpacePortDockingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DockingController : ControllerBase
    {
        [HttpGet]
        [ActionName("pingTower")]
        [Route("/tower/ping")]
        public ActionResult<string> TestJSON()
        {
            return JSONHandler.appOptions.textContent.towerTextContent.pingMesssage;
        }
    }
}
