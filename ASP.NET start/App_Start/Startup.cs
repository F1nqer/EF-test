﻿using ASP.NET_start.UserServiceRef;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[assembly: OwinStartup(typeof(Shop.App_Start.Startup))]
namespace Shop.App_Start
{
    public class Startup
    {
        UserServiceClient client = new UserServiceClient();
        public void Configuration(IAppBuilder app)
        {
            app.CreatePerOwinContext<UserServiceClient>(CreateUserService);
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),
            });
        }

        private UserServiceClient CreateUserService()
        {
            return new UserServiceClient();
        }
    }
}