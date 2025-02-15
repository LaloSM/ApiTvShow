﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tvshow.Application.Features.Auth.Users.Vms
{
    public class AuthResponse
    {
        public string? Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Telefono { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Token { get; set; }
        public string? Avatar { get; set; }
        public ICollection<string>? Roles { get; set; }
    }
}
