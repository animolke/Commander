using Commander.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Commander.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int Id);
        bool CreateCommand(Command command);
        bool SaveChanges();
        bool UpdateCommand(Command command);
    }
}
