using AuthServer.Core.Dtos;
using AuthServer.Core.Model;
using SharedLibrary.Dtos;
using System.Threading.Tasks;

namespace AuthServer.Core.Services
{
    public interface IUserService
    {
        Task<Response<UserApp>> CreateUserAsync(CreateUserDto createUserDto);
        Task<Response<UserAppDto>> GetUserByName(string userName);
    }
}
