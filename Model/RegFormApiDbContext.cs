using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegFormApi.Model
{
    public class RegFormApiDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
    }
}
