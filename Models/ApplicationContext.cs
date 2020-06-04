﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BID_E.Models
{
    public class ApplicationContext :DbContext
    {
        public ApplicationContext()
        {

        }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
           : base(options)
        {

        }

        public virtual DbSet<Login> Login { get; set; }
    }
}
