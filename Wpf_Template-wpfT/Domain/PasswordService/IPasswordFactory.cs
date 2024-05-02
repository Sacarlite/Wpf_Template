namespace Domain.PasswordService;

public interface IPasswordFactory
{
    string GetHashPassword(string password);
}