using AuthServer.Core.Dtos;
using SharedLibrary.Dtos;
using System.Threading.Tasks;

namespace AuthServer.Core.Services
{
    public interface IAuthenticationService
    {
        Task<Response<TokenDto>> CreateTokenAsync(LoginDto loginDto);
        Task<Response<TokenDto>> CreateTokenByRefreshTokenAsync(string refreshToken);
        Task<Response<NoDataDto>> RevokeRefreshToken(string refreshToken);
        Task<Response<ClientTokenDto>> CreateTokenByClient(ClientLoginDto clientLoginDto);
    }
}
