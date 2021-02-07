using System.Threading.Tasks;
using Posts.Application.Commands;

namespace Posts.Application.CommandHandlers
{
    public interface ICommandHandler<TCommand> where TCommand : ICommand
    {
        Task Handle(TCommand command);
    }
}
