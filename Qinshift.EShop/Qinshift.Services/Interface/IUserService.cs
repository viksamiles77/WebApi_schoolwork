using Qinshift.EShop.DTOs.User;

namespace Qinshift.EShop.Services.Interface
{
    public interface IUserService
    {
        string LoginUser(string username, string password);
        int RegisterUser(RegisterUserDto registerUserDto);
    }
}
