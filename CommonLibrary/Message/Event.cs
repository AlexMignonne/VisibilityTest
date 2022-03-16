using MediatR;

namespace CommonLibrary.Message
{
    public abstract class Event
        : Message, INotification
    {
    }
}
