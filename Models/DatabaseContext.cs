using BID_E.Models;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SQLite.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext( )
        {
           
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {

        }

        public virtual DbSet<General> General{ get; set; }

        public virtual DbSet<General> Register { get; set; }
    }
}
