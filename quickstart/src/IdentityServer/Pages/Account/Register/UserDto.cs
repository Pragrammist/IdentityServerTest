using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer.Pages.Register
{
    public record UserDto(int Id,string Login, string PasswordHash);
}