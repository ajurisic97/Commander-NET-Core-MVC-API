using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public interface ICommanderRepo
    {
        bool SaveChanges();
        //give me list of all command objects
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        
        void CreateCommand(Command cmd);

        void UpdateCommand(Command cmd);

        void DeleteCommand(Command cmd);


    }
}