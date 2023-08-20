using Microsoft.Extensions.Hosting;
using Core.Messages;

namespace Core.Interfaces
{
    public interface IEventConsumer<TMessage, TPrimaryKey>
        where TMessage : class, IMessage<TPrimaryKey>
    {
        void Subscribe();
        void Unsubscribe();
    }
}
