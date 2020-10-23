using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CommandAPI.Models;

namespace CommandAPI.Data
{

    // This class represents the database and mediates between Models and DB
    public class CommandContext : DbContext
    {
        // Constructor
        public CommandContext(DbContextOptions<CommandContext> options)
            : base(options)
        {
            
        }

        // DbSet represents a table in the DB
        // Tells DbContext class we want to model our commands in the DB
        // so they can be stored as a table
        public DbSet<Command> CommandItems { get; set; }

    }
}
