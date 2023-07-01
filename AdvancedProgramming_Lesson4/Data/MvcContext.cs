using AdvancedProgramming_Lesson4.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedProgramming_Lesson4.Data
{
    public class MvcContext : DbContext
    {
        public MvcContext(DbContextOptions<MvcContext> options)
        : base(options)
        {
        }
        public DbSet<ChatMessage> ChatMessage { get; set; }
    }
}
