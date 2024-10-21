﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.Application.Interfaces
{
    public interface ITokenService
    {
        string GenerateToken(string username, string role);
    }
}
