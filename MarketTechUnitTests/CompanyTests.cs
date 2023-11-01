using MarkelTechTest;
using MarkelTechTest.Controllers;
using MarkelTechTest.Interface;

namespace MarketTechUnitTests
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetCompany()
        {
            // Arrange
            var testCompany = new Company
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

            ICompanyRepository mockCompanyRepository = new CompanyRepositoryMock();
            var controller = new CompanyController(mockCompanyRepository);

            // Act
            var result = controller.Get(2).First();

            // Assert
            Assert.That(result.Id, Is.EqualTo(testCompany.Id));
        }
    }
}