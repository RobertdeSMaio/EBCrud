using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_.Domains.DTO
{
    public class LoginDTO //DTO = data transfer objects || transfarindo o obj email && senha para DB
    {
        public string Email { get; set; } = default!;
        public string Password { get; set; } = default!;
    }
}