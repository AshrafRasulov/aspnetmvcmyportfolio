namespace MyPortfolioWebAPI.Data.Models
{
    public class User
    {
        public int ID { get; set; }
        public string? Email { get; set; }
        public string? Fname { get; set; }
        public string? Lname { get; set; }
        public int Age { get; set; }
        public int SkillLevel { get; set; } //Starter, Junior, Sinior

        //Navigation Properties

        public int PortfolioId { get; set; }
        public List<Contact>? Contacts { get; set; }
    }
}
