using AdvancedProgramming_Lesson4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using AdvancedProgramming_Lesson4.Migrations;
using System.Dynamic;
using Azure.Identity;
using Microsoft.EntityFrameworkCore.Migrations;
using AdvancedProgramming_Lesson4.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using Microsoft.Data.SqlClient;

namespace AdvancedProgramming_Lesson4.Pages
{
    public class UsersModel : PageModel
    {
        private readonly AdvancedProgramming_Lesson4.Data.ApplicationDbContext _context;

        public UsersModel(AdvancedProgramming_Lesson4.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Microsoft.AspNetCore.Identity.IdentityUser> AspNetUsers { get; set; }

        public async Task OnGetAsync()
        {
            AspNetUsers = await _context.AspNetUsers.ToListAsync();
        }
    }

}

