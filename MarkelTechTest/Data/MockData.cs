namespace MarkelTechTest.Data
{
    public class MockData
    {
        /// <summary>
        /// Mock Company Database Table
        /// </summary>
        public static IEnumerable<Company> Companies = new Company[] {
            new Company()
            {
                Id = 0,
                Name = "Company One",
                Address1 = "9",
                Address2 = "Company Drive",
                Address3 = "York",
                PostCode = "YO10 1AB",
                Country = "UK",
                Active = true,
                InsuranceEndDate = new DateTime(2024, 01, 01),
            },
            new Company()
            {
                Id = 1,
                Name = "Company Two",
                Address1 = "10",
                Address2 = "Company Two Drive",
                Address3 = "York",
                PostCode = "YO10 1BC",
                Country = "UK",
                Active = true,
                InsuranceEndDate = new DateTime(2023, 01, 01)
            },
            new Company()
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
            }
        };

        /// <summary>
        /// Mock Claim Database Table
        /// </summary>
        public static IEnumerable<Claim> Claims = new Claim[] {
            new Claim()
            {
                UCR = "UCR1",
                Name = "Company One Claim One",
                CompanyId = 1,
                ClaimDate = new DateTime(2023, 01, 01),
                LossDate = new DateTime(2023, 01, 01),
                AssuredName = "Assured Name One",
                IncurredLoss = 120.26,
                Closed = false
            },            
            new Claim()
            {
                UCR = "UCR2",
                Name = "Company One Claim Two",
                CompanyId = 1,
                ClaimDate = new DateTime(2023, 01, 01),
                LossDate = new DateTime(2023, 01, 01),
                AssuredName = "Assured Name two",
                IncurredLoss = 130.26,
                Closed = false
            },
        };
    }
}
