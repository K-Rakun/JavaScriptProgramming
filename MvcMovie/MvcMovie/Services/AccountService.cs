namespace MvcMovie.Service
{
    public class AccountService : IAccountService
    {
        public bool AuthenticateUser(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                return false;
            }

            return (userName.ToLower() == "admin" && password == "adminPass") ||
            (userName.ToLower() == "userx" && password == "userPass");
        }

        public string GetUserRole(string userName)
        {
            if (userName == "admin")
            {
                return "Administrators";
            }
            else if (userName == "userx")
            {
                return "Users";
            }

            return null;
        }
    }
}
