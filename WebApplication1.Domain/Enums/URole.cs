using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Domain.Entities;

namespace WebApplication.Domain.Enums
{
    public enum URole
    {
        User = 0,
        Moderator = 1,
        Admin = 2//cand te loghezi pe site ii pui utilizatorului ce rol sa aiba
    }
}
