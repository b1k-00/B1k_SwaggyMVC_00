using Adventure.Domain;

namespace Adventure
{
    public interface IUserApp
    {
        bool CreateUser(User user);

        bool ValidateUser(string username, string password);

        bool DeleteUser(User user);

    }
}
