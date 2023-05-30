// Assembly 'System.Cloud.Messaging.Abstractions'

namespace System.Cloud.Messaging;

public interface IMessageVisibilityDelayFeature
{
    TimeSpan VisibilityDelay { get; }
}
