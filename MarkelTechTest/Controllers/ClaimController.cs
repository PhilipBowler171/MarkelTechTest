using MarkelTechTest.Data;
using Microsoft.AspNetCore.Mvc;

namespace MarkelTechTest.Controllers
{
  
    [ApiController]
    [Route("[controller]")]
    public class ClaimController : ControllerBase
    {
        private readonly ILogger<CompanyController> _logger;

        public ClaimController(ILogger<CompanyController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{ucr}")]
        public IEnumerable<Claim> Get(string ucr)
        {
            yield return ClaimRepository.GetClaim(ucr);
        }

        [HttpPost(Name = "UpdateClaim")]
        public void Post(string ucr,
                         bool? closed,
                         int? companyId,
                         string? name,
                         double? incurredLoss,
                         DateTime claimDate = new DateTime(),
                         DateTime lossDate = new DateTime(),
                         string? assuredName = null
                         )
        {


            ClaimRepository.Update(ucr,
                                    companyId,
                                    name,
                                    claimDate,
                                    lossDate,
                                    assuredName,
                                    incurredLoss,
                                    closed);

        }
    }
}
