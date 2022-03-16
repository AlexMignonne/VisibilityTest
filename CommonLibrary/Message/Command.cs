using MediatR;

namespace CommonLibrary.Message
{
    public abstract class Command<TResponse>
        : Message, IRequest<TResponse>
    {
    }

    public abstract class Command
        : Message, IRequest
    {
    }
}
