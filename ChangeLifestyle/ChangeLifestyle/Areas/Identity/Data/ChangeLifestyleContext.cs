﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChangeLifestyle.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ChangeLifestyle.Data
{
    public class ChangeLifestyleContext : IdentityDbContext<ChangeLifestyleUser>
    {
        public ChangeLifestyleContext(DbContextOptions<ChangeLifestyleContext> options)
            : base(options)
        {
        }
        public DbSet<ChangeLifestyleUser> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
