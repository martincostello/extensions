// Assembly 'System.Cloud.Messaging.Abstractions'

using System.Threading;
using System.Threading.Tasks;

namespace System.Cloud.Messaging;

public interface IMessagePostponeFeature
{
    ValueTask PostponeAsync(TimeSpan delay, CancellationToken cancellationToken);
}
