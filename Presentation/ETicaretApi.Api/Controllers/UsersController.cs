using ETicaretApi.Application.Features.Commands.AppUser.CreateUser;
using ETicaretApi.Application.Features.Commands.FacebookLogin;
using ETicaretApi.Application.Features.Commands.GoogleLogin;
using ETicaretApi.Application.Features.Commands.LoginUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserCommandRequest createUserCommandRequest)
        {
            CreateUserCommandResponse response = await _mediator.Send(createUserCommandRequest);
            return Ok(response);
        }   
    }
}
