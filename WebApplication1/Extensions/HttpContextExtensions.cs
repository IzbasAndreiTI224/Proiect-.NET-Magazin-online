﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication.Domain.Entities.User;

namespace WebApplication1.Extensions
{
    public static class HttpContextExtensions
    {
        public static UserMinimal GetMySessionObject(this HttpContext current)
        {
            return (UserMinimal)current?.Session["__SessionObject"];
        }

        public static void SetMySessionObject(this HttpContext current, UserMinimal profile)
        {
            current.Session.Add("__SessionObject", profile);
        }
    }
}