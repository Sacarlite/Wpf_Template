using Domain.PasswordService;

namespace PasswordService;

public class PasswordService: IPasswordFactory, IPasswordValidation
{
    public string GetHashPassword(string password)
    {
        throw new NotImplementedException();
    }

    public bool IsValid(string password)
    {
        throw new NotImplementedException();
    }
}