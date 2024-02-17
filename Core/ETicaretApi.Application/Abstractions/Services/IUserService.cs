using ETicaretApi.Application.DTOs.User;

namespace ETicaretApi.Application.Abstractions.Services
{
    public interface IUserService
    {
        Task<CreateUserResponse> CreateAsync(CreateUser model);
    }
}
