using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Domain.Entities.User;
using WebApplication1.Domain.Entities.User;

namespace WebApplication1.BusinessLogic.MainBL
{
    public class SessionContext : DbContext
    {
        public SessionContext() :
            base("name=WebApplication2")
        {
        }

        public virtual DbSet<Session> Sessions { get; set; }
    }
}

