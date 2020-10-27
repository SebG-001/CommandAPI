using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommandAPI.Models;


namespace CommandAPI.Data
{
    public class SqlCommandAPIRepo : ICommandAPIRepo
    {
        // Constructor that has the database context injected by the runtime 
        // so it can be used here using _context variable
        private readonly CommandContext _context;
        // Constructor
        public SqlCommandAPIRepo(CommandContext context)
        {
            _context = context; 
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void CreateCommand(Command cmd)
        {
            if (cmd == null) {
                throw new ArgumentNullException(nameof(cmd));
            }
            _context.CommandItems.Add(cmd);
        }

        public void DeleteCommand(Command cmd)
        {
            if (cmd == null) {
                throw new ArgumentNullException(nameof(cmd));
            }
            _context.CommandItems.Remove(cmd);
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.CommandItems.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.CommandItems.FirstOrDefault(p => p.Id == id);
        }



        public void UpdateCommand(Command cmd)
        {
            // No code needs to be done here since Entity Framework keeps track of the
            // command object used to determine if the Id exists and is updated in the
            // controller where SaveChanges is called.
        }
    }
}
