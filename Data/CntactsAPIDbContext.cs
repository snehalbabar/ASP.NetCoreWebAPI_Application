using System;
using ContactAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactAPI.Data
{
    public class CntactsAPIDbContext : DbContext
    {
        public CntactsAPIDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Contact> Contacts{ get; set; }

    }
}

