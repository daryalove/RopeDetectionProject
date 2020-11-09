using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace RopeDetection.Entities.Context
{
    public class UserContextFactory: IDesignTimeDbContextFactory<UserContext>
    {
        public UserContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<UserContext>();
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-25321UL;Initial Catalog=1gb_testdb;User Id=dbadmin;Password=qwerty_123;MultipleActiveResultSets=True");

            return new UserContext(optionsBuilder.Options);
        }
    }
}
