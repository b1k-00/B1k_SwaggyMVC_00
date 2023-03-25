namespace Adventure.Domain
{
    public class User : BaseEntity
    {
        public int iD { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; } 


    }
}
