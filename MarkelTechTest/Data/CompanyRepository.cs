using MarkelTechTest.Interface;

namespace MarkelTechTest.Data
{
    public class CompanyRepository : ICompanyRepository
    {
        public Company GetCompany(int id)
        {
            var company = MockData.Companies.FirstOrDefault(c => c.Id == id);
            
            if (company != null)
              company.HasActiveInsurcePolicy = company.InsuranceEndDate > DateTime.Now && company.Active;

            return company;
        }

    }
}
