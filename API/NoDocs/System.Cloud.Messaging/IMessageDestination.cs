// Assembly 'System.Cloud.Messaging.Abstractions'

using System.Threading.Tasks;

namespace System.Cloud.Messaging;

public interface IMessageDestination
{
    ValueTask WriteAsync(MessageContext context);
}
