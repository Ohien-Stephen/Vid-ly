using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Vid_ly.Data;
using Vid_ly.Data.Models;

[assembly: HostingStartup(typeof(Vid_ly.Areas.Identity.IdentityHostingStartup))]
namespace Vid_ly.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {}
    }
}