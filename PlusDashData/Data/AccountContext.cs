﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskManager.Models.BoardsPageModels;

namespace TaskManager.Models
{
    public class AccountContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<PersonalCard> PerCards {get; set;}
        public DbSet<PersonalDashboard> PerDashBoards { get; set; }
        public DbSet<MultiDashboard> MultiDashBoards { get; set; }
        public AccountContext(DbContextOptions<AccountContext> options):base(options)
        {
            Database.EnsureCreated();
        }

    }
}