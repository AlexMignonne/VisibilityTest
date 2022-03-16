using MediatR;

using System.Threading;
using System.Threading.Tasks;

namespace CommonLibrary.Message
{
    public abstract class EventHandler : INotificationHandler<Event>
    {
        public abstract Task Handle(Event notification, CancellationToken token);
    }
}
