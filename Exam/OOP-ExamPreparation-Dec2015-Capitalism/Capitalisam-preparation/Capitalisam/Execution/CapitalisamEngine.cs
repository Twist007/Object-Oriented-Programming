using Capitalisam.Interfaces;
using Capitalisam.UserInterface;

namespace Capitalisam.Execution
{
    public class CapitalisamEngine : IEngine
    {
        private IUserInterface userInterface;
        private ICommandExecutor commandExecutor;

        public CapitalisamEngine()
        {
            this.userInterface = new ConsoleUserInterface();
            this.commandExecutor = new CapitalisamComamndExecutor();
        }

        public void Run()
        {
            string commandLine = this.userInterface.ReadLine();
            var command = new Command(commandLine);
            string commandResult=this.commandExecutor.ExecuteCommand(command);
            if (commandResult!=null)
            {
                this.userInterface.WriteLine(commandResult);
            }
        }
    }
}