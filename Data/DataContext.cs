using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;


namespace API.Data;


    public class DataContext(DbContextOptions options) : DbContext(options)
    {

        public DbSet<AppUser> Users { get; set; }


   }

    

