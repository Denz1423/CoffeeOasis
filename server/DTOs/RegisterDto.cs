using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using server.DTOs;

namespace server.DTOs
{
    public class RegisterDto : LoginDto
    {
        public string Email { get; set; }

    }
}