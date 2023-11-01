namespace MarkelTechTest.Data
{
    public class ClaimRepository
    {

        // I am assuming UCR stands for UNIQUE claim reference?
        public static Claim GetClaim(string ucr)
        {
            var claim = MockData.Claims.FirstOrDefault(c => c.UCR == ucr);

            if (claim != null)
                claim.DaysOld = (DateTime.Now - claim.ClaimDate).Days;

            return claim;
        }

        public static IEnumerable<Claim> GetClaims(int companyId)
        {
            var claims = MockData.Claims.Where(x => x.CompanyId == companyId);

            return claims;
        }

        public static void Update(string ucr,
                                  int? companyId,
                                  string? name,
                                  DateTime? claimDate,
                                  DateTime? lossDate,
                                  string? assuredName,
                                  double? incurredLoss,
                                  bool? closed)
        {

            var claim = MockData.Claims.FirstOrDefault(c => c.UCR == ucr);

            if(claim != null)
            {
                claim.CompanyId = companyId != null ? companyId.Value : claim.CompanyId;
                claim.Name = name ?? claim.Name;
                claim.ClaimDate = claimDate != null ? claimDate.Value : claim.ClaimDate;
                claim.LossDate = lossDate != null ? lossDate.Value : claim.LossDate; 
                claim.AssuredName = assuredName ?? claim.AssuredName;
                claim.IncurredLoss = incurredLoss != null ? incurredLoss.Value : claim.IncurredLoss;
                claim.Closed = closed != null ? closed.Value : claim.Closed;
            }
        }
    }
}
