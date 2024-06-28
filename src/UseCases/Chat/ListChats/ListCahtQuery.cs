
using UseCases.Common;
using UseCases.Interfaces;

namespace UseCases.Chat.ListChats;

public record ListChatQuery(string options = null) : IQuery<Result>;

public class ListChatHAndler : IQueryHandler<ListChatQuery, Result>
{
    public Task<Result> Handle(ListChatQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}