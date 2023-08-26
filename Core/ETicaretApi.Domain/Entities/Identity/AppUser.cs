using Microsoft.AspNetCore.Identity;

namespace ETicaretApi.Domain.Entities.Identity
{
    public class AppUser : IdentityUser<string>
    {
        public string NameSurname { get; set; }
    }
}
