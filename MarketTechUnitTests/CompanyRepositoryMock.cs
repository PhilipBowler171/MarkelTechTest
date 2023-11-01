using MarkelTechTest;
using MarkelTechTest.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketTechUnitTests
{
    internal class CompanyRepositoryMock : ICompanyRepository
    {
        public Company GetCompany(int id)
        {
            var company = new Company
            {
                Id = 2,
                Name = "Company Three",
                Address1 = "11",
                Address2 = "Company Three Drive",
                Address3 = "York",
                PostCode = "YO10 1CD",
                Country = "UK",
                Active = true,
                InsuranceEndDate = new DateTime(2025, 01, 01)
            };

            return company;
        }
    }
}
