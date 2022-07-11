using AuthServer.Core.Configuration;
using AuthServer.Core.Dtos;
using AuthServer.Core.Model;

namespace AuthServer.Core.Services
{
    public interface ITokenService
    {
        TokenDto CreateToken(UserApp userApp);
        ClientTokenDto CreateTokenByClinet(Client client);
    }
}
