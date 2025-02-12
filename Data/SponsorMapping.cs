namespace BlazorServerApp1.Data
{
    // SponsorMapping Model
    public class SponsorMapping
    {
        public int Id { get; set; }
        public string CertificateName { get; set; }
        public List<string> SponsorList { get; set; }
    }
}
