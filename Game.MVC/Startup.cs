﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Game.MVC.Startup))]
namespace Game.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
