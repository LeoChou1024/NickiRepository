using GitProject.Service;

LoginService service = new LoginService();
bool checkLogin = service.Login("leo","123");
if (checkLogin)
{
    Console.WriteLine("登入成功");
}
else
{
    Console.WriteLine("登入失敗");
}