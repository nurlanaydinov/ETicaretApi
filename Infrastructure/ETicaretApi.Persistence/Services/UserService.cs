using ETicaretApi.Application.Abstractions.Services;
using ETicaretApi.Application.DTOs.User;
using Microsoft.AspNetCore.Identity;

namespace ETicaretApi.Persistence.Services
{
    public class UserService : IUserService
    {
        readonly UserManager<ETicaretApi.Domain.Entities.Identity.AppUser> _userManager;

        public UserService(UserManager<Domain.Entities.Identity.AppUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<CreateUserResponse> CreateAsync(CreateUser model)
        {
            IdentityResult result = await _userManager.CreateAsync(new()
            {
                Id = Guid.NewGuid().ToString(),
                NameSurname = model.NameSurname,
                UserName = model.UserName,
                Email = model.Email
            }, model.Password);

            CreateUserResponse response = new() { Succeeded = result.Succeeded };

            if (result.Succeeded)
            {
                response.Message = "User added succesfully!";
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    response.Message += $"{error.Code} - {error.Description}<br>";
                }
                //throw new UserCreateFailedException();
            }
            return response;
        }
    }
}
