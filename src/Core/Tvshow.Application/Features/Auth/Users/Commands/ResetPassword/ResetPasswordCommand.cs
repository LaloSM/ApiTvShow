﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tvshow.Application.Features.Auth.Users.Commands.ResetPassword
{
    public class ResetPasswordCommand : IRequest
    {
        public string? NewPassword { get; set; }
        public string? OldPassword { get; set; }
    }
}
