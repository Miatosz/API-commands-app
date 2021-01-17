using System.Collections.Generic;
using Commander.Models;

namespace Commander.Repositories
{
    public interface ICommanderRepository
    {

        bool SaveChanges(); 

        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        void CreateCommand(Command command);
        void UpdateCommand(Command command);
        void DeleteComand(Command command);
    }
}