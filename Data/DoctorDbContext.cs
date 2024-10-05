﻿using ContactDoctor.Models;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Data
{
    public class DoctorDbContext:DbContext
    {
       public DbSet<Doctor> Doctors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json",true,true).Build();
           var connection= builder.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connection);

        }


    }
}
