using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public interface ICommanderRepo
    {
        //give me list of all command objects
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        

    }
}