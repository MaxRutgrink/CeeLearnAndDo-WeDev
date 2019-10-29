using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CeeLearnAndDo_WeDev.Models;

namespace CeeLearnAndDo_WeDev.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CeeLearnAndDo_WeDev.Models.Consultant> Consultant { get; set; }
        public DbSet<CeeLearnAndDo_WeDev.Models.Question> Question { get; set; }
    }
}
