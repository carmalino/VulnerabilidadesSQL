﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VulnerabilidadesSQL.API.Data.Entities;

namespace VulnerabilidadesSQL.API.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }

        public DbSet<New> News { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
