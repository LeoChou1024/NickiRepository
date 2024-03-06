namespace GitProject.Service;

public class LoginService
{
    private LoginAccount login = null;
    public LoginService()
    {
        this.login = new LoginAccount();
    }

    public bool Login(string account,string password)
    {
        this.login.Account = account;
        this.login.Password = password;

        return true;

    }
    
}