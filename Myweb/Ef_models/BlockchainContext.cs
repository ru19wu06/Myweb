﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Myweb.Ef_model
{
    public partial class BlockchainContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;user id=root;password=admin;persistsecurityinfo=True;database=blockchain", x => x.ServerVersion("8.0.21-mysql"));
            }
        }
    }
}