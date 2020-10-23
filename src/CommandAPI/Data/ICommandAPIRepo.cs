using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommandAPI.Models;

namespace CommandAPI.Data
{
    // This is an interface contract for the user of our API
    // that is, the user will know what interface methods/properties 
    // are available to them
    // This describes the repository interface that will be used to 
    // access and modify the database
    // It is formalized as an interface so as to lock the contract between
    // the API and User
    public interface ICommandAPIRepo
    {
        bool SaveChanges();
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        void CreateCommand(Command cmd);
        void UpdateCommand(Command cmd);
        void DeleteCommand(Command cmd);
    }
}
