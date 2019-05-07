using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebASPNETCore.Models;

namespace WebASPNETCore.Repository
{
    public class DBContext:DbContext
    {
        public DBContext(DbContextOptions<DBContext>options):base(options)
        {

        }
        public DbSet<Admin> AdminLogin { get; set; }
        public DbSet<TopMenu> TopMenu { get; set; }
        public DbSet<WebPage> WebPage { get; set; }
        public DbSet<PostForPage> PostForPage { get; set; }


    }
}
