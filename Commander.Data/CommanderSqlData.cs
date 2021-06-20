using Commander.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Commander.Data
{
    public class CommanderSqlData : ICommanderRepo
    {
        private readonly CommandsContext _db;

        public CommanderSqlData(CommandsContext db)
        {
            this._db = db;
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return from c in _db.Commands
                   orderby c.Id
                   select c;
        }

        public Command GetCommandById(int Id)
        {
            return _db.Commands.FirstOrDefault(c => c.Id == Id);
        }

        public int commit() 
        {
            return _db.SaveChanges();
        }

        public bool CreateCommand(Command command)
        {
            if (command == null) 
            {
                throw new ArgumentNullException(nameof(Command));
            }

            _db.Commands.Add(command);
            return true;
        }

        public bool SaveChanges()
        {
            return (_db.SaveChanges() >= 0);
        }

        public bool UpdateCommand(Command command)
        {
            //not required to implement anything on database side this will be taken care by EF automatically
            //as a result of Dto mapping
            if (command == null) 
            {
                throw new ArgumentNullException(nameof(Command));
            }

            return true;
        }
    }
}
