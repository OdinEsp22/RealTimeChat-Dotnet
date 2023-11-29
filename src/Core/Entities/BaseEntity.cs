namespace Core.Entities;
public abstract class BaseEntity 
{
    public BaseEntity(){
        Id = new Guid();
        DateCreated = DateTime.Now;
    }
    protected Guid Id {get; private set;}
    protected DateTime DateCreated {get; private set;}
    protected DateTime DateEdited {get; private set;}
    protected DateTime DateDeleted {get; private set;}

}