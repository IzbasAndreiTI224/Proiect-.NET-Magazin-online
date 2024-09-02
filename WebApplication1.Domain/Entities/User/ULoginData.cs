using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Domain.Entities.User
{
    public class ULoginData
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Ip { get; set; }
        public DateTime LoginTime { get; set; }

    }
}


