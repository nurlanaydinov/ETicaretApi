using ETicaretApi.Application.DTOs.User;
using ETicaretApi.Domain.Entities.Identity;

namespace ETicaretApi.Application.Abstractions.Services
{
    public interface IUserService
    {
        Task<CreateUserResponse> CreateAsync(CreateUser model);
        Task UpdateRefreshToken(string refreshToken, AppUser user, DateTime accessTokenDate, int addOnAccessTokenDate);
    }
}
