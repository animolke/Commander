using Commander.Core;
using System.Collections.Generic;
using System.Linq;

namespace Commander.Data
{
    public class InMemoryData : ICommanderRepo
    {
        private readonly IEnumerable<Command> commands;

        public InMemoryData()
        {
            commands = new List<Command>() { 
                new Command { Id = 0, HowTo = "Boil water for tea", Line = "Make Tea", Platform = "Beverages" },
                new Command { Id = 1, HowTo = "Cut veggies for salad", Line = "Make Salad", Platform = "Salads" },
                new Command { Id = 2, HowTo = "Cut paper strips", Line = "Decorate house", Platform = "Decor" }
            }; 
        }

        public bool CreateCommand(Command command)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return from c in commands
                   orderby c.Id
                   select c;
        }

        public Command GetCommandById(int Id)
        {
            return commands.FirstOrDefault(c => c.Id == Id);
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateCommand(Command command)
        {
            throw new System.NotImplementedException();
        }
    }
}
