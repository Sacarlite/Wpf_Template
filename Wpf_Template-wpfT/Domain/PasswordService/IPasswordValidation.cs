namespace Domain.PasswordService;

public interface IPasswordValidation
{
    bool IsValid(string password);
}