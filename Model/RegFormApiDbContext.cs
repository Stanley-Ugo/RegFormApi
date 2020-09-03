using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegFormApi.Model
{
    public class RegFormApiDbContext : DbContext
    {
        public RegFormApiDbContext(DbContextOptions<RegFormApiDbContext> options)
           : base(options)
        {

        }
        public DbSet<Person> Persons { get; set; }
    }
}
