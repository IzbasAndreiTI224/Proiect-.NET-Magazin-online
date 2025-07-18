﻿
using AutoMapper;
using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using WebApplication.Domain.Entities.User;
using WebApplication1.App_Start;
using WebApplication1.Domain.Entities.User;
using WebApplication1.Models.User;

namespace WebApplication1
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            
            // Code that runs on application startup
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            InitializeAutoMapper();
        }
        protected static void InitializeAutoMapper()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<UserLogin, ULoginData>();
                cfg.CreateMap<UserRegister, URegisterData>();
            });
        }
    }
}