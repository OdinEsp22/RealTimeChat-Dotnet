using Core.Entities.MessageAgregate;
using Core.Interfaces;

namespace Core.Services;

public class MessageService : IMessageService 
{

    private readonly IRepository<Message> _messageReposirtory;

    public MessageService(IRepository<Message> repository)
    {
        this._messageReposirtory = repository;
    }
}