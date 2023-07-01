using AdvancedProgramming_Lesson4.Data.Migrations;
using AdvancedProgramming_Lesson4.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedProgramming_Lesson4.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Microsoft.AspNetCore.Identity.IdentityUser> AspNetUsers { get; set; }
    }
}
