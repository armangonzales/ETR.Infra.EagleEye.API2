using ETR.Infra.EagleEye.API2.Data;
using ETR.Infra.EagleEye.API2.Models;
using Microsoft.AspNetCore.Mvc;

namespace ETR.Infra.EagleEye.API2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PulseController : Controller
    {
        private readonly etrEagleEyeDbContext dbContext;
        public PulseController(etrEagleEyeDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetPulseLogs()
        {
            return Ok("true");
            
        }

        [HttpPost]
        public async Task<IActionResult> AddetrEagleEye(string computer, string status, string taskid)
        {
            var pulseLog = new PulseLogs
            {
               
                Computer = computer,
                Status = status,
                TaskId = taskid
            };

             await dbContext.PulseLog.AddAsync(pulseLog);
             await dbContext.SaveChangesAsync();

            return Ok(pulseLog);
        }

    }
}
