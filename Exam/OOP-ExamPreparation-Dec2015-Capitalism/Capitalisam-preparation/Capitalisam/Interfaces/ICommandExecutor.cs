namespace Capitalisam.Interfaces
{
    public interface ICommandExecutor
    {
        //TODO: Should this return string
        string ExecuteCommand(ICommand command);
    }
}