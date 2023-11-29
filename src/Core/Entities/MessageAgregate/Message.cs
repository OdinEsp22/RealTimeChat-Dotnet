namespace Core.Entities.MessageAgregate;

public class Message : BaseEntity
{
    public Guid UserId {get; set;}
    public DateTime DateSend {get; set;}
    public string UserName {get; set;} = "";


}