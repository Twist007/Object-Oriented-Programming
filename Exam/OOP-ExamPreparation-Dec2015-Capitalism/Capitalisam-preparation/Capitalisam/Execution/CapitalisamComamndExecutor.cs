using System;
using Capitalisam.Interfaces;
using Capitalisam.Models;

namespace Capitalisam.Execution
{
    public class CapitalisamComamndExecutor : ICommandExecutor
    {
        private IDatabases databases;
        private IUserInterface userInterface;

        public CapitalisamComamndExecutor()
        {
            this.databases = new CapitalismDatabases();
        }
        public string ExecuteCommand(ICommand command)
        {
            switch (command.Name)
            {
                case "create-company":
                    //TODO:Refactor to use proper constructors
                    //var ceo=new CEO() {FirstName = command.Parameters[1],LastName = command.Parameters[2],Salary = decimal.Parse(command.Parameters[3])};
                    this.databases.Companies.Add(new Company(command.Parameters[0],ceo));
                    break;
                case "create-departament":
                    break;
                case "create-employee":
                    break;
                case "pay-salaries":
                    break;
                case "show-employees":
                    //TODO:implement this
                    return "Eployees go here.";
                case"end":
                    break;
                default:
                    throw new InvalidOperationException("The command name is invalid");
            }
            return null;
        }
    }
}