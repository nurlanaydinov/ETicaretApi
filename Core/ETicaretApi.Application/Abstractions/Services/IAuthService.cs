using ETicaretApi.Application.Abstractions.Services.Authentications;

namespace ETicaretApi.Application.Abstractions.Services
{
    public interface IAuthService : IExternalAuthentication, IInternalAuthentication
    {
    }
}
