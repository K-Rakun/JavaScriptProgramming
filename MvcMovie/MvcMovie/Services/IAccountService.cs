namespace MvcMovie.Service
{
    public interface IAccountService
    {
        bool AuthenticateUser(string userName, string password);

        string GetUserRole(string userName);
    }
}
