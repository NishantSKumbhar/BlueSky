﻿using BlueSky.Models;
using Microsoft.EntityFrameworkCore;

namespace BlueSky.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        { 
            
        }

        public DbSet<Contact> Contacts { get; set; }


    }
}
