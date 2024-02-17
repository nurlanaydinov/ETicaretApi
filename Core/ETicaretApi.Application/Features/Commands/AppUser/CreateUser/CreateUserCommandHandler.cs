using ETicaretApi.Application.Abstractions.Services;
using ETicaretApi.Application.DTOs.User;
using MediatR;

namespace ETicaretApi.Application.Features.Commands.AppUser.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
    {
        readonly IUserService _userService;

        public CreateUserCommandHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
        {
            CreateUserResponse response = await _userService.CreateAsync(new()
            {
                Email = request.Email,
                NameSurname = request.NameSurname,
                Password = request.Password,
                RepeatPassword = request.RepeatPassword,
                UserName = request.UserName
            });  
     
            return new()
            {
                Message = response.Message,
                Succeeded = response.Succeeded
            };
        }
    }
}
