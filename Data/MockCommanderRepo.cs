using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>{
                new Command{Id=0,HowTo="Drink",Line="Boil water",Platform="Pan"},
                new Command{Id=1,HowTo="Cut bread",Line="Get a knife",Platform="Chopping board"},
                new Command{Id=2,HowTo="Make cup of tea",Line="Place teabag in cup",Platform="Cup"}
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0,HowTo="Drink",Line="Boil water",Platform="Pan"};
        }
    }
}