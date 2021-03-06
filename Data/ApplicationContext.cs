using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC.Models;
using MVC.Data;

namespace MVC.Data{

    public class ApplicationContext : DbContext
    {
        public ApplicationContext (DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<Mvc.Models.Movie> Movie { get; set; }

        public DbSet<Mvc.Models.Student> Student { get; set; }
    }
}