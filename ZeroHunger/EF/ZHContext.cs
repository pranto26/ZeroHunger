using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ZeroHunger.EF.Models;

namespace ZeroHunger.EF
{
    public class ZHContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Employee> Emoloyees { get; set; }
        public DbSet<Request> Requests { get; set; }
    }
}