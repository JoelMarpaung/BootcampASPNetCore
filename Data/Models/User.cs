using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models
{
    public class User : BaseModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

    }
}
