namespace MyPortfolioWebAPI.Data.Models
{
    public class Contact
    {
        public int ContactID { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Gmail { get; set; }
        public string? Facebook { get; set; }
        public string? Linkedin { get; set; }
        public string? PersonalSite { get; set; }

        //
        public User? User { get; set; }
    }
}
