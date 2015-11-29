namespace SecretSanta.Models
{
    public class DistributionViewModel
    {
        public string Name { get; set; }
        public bool PersonExists { get; set; }
        public int Budget { get; set; }
        public bool AlreadyAssigned { get; set; }
        public string GroupName { get; set; }
    }
}