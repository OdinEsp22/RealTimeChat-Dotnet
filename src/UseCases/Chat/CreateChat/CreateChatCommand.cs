
using UseCases.Common;
using UseCases.Interfaces;

namespace UseCases.Chat.CreateChat;

public record CreateChateCommand (string name) : ICommand<Result>;

public class CreateChatHandler : ICommandHadler<CreateChateCommand, Result>
{
    public Task<Result> Handle(CreateChateCommand request, CancellationToken cancellationToken)
    {
        //implement the logig here

        return null;
    }
}
