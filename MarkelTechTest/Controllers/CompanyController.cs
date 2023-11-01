using MarkelTechTest.Data;
using MarkelTechTest.Interface;
using Microsoft.AspNetCore.Mvc;

namespace MarkelTechTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyRepository _repository = new CompanyRepository();

        public CompanyController(ICompanyRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("{id:int}")]
        public IEnumerable<Company> Get(int id)
        {
            yield return _repository.GetCompany(id);
        }


        [HttpGet("{id:int}/Claims")]
        public IEnumerable<Claim> GetCompanyClaims(int id)
        {
            return ClaimRepository.GetClaims(id);
        }

    }
}
