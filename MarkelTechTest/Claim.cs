namespace MarkelTechTest
{
    public class Claim
    {
        public string UCR { get; set; }
        public string Name { get; set; }
        public int CompanyId { get; set; }
        public DateTime ClaimDate { get; set; }
        public DateTime LossDate { get; set; }
        public string AssuredName { get; set; }
        public double IncurredLoss { get; set; }
        public bool Closed { get; set; }
        public int DaysOld { get; set; }
    }
}
