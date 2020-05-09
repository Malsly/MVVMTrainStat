using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Entities;

namespace RepositoryUoW.Data
{
    public class RepositoryUoWContext : DbContext
    {
        public RepositoryUoWContext (DbContextOptions<RepositoryUoWContext> options)
            : base(options)
        {
        }

        public DbSet<Entities.Station> Station { get; set; }

        public DbSet<Entities.Train> Train { get; set; }

        public DbSet<Entities.Passanger> Passanger { get; set; }

        public DbSet<Entities.Ticket> Ticket { get; set; }
    }
}
