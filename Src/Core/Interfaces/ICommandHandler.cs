using Core.Commands;

namespace Core.Interfaces
{
    public interface ICommandHandler<in T>  where T : CommandBase
    {
        Result Handle(T command);
    }
}