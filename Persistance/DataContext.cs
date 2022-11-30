using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistance
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        /// <summary>
        /// Sets the database table based on the entity passed in
        /// </summary>
        public DbSet<Activity> Activities { get; set; }


    }
}