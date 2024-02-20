using ETicaretApi.Domain.Entities.Identity;

namespace ETicaretApi.Application.Abstractions.Token
{
    public interface ITokenHandler
    {
        DTOs.Token CreateAccessToken(int second, AppUser user);
        string CreateRefreshToken();
    }
}
