using Commander.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Commander.Data
{
    public class CommandsContext : DbContext
    {
        public CommandsContext(DbContextOptions<CommandsContext> options)
            :base(options)
        {

        }

        public DbSet<Command> Commands { get; set; }
    }
}
