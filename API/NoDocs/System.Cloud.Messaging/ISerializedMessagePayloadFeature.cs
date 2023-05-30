// Assembly 'System.Cloud.Messaging.Abstractions'

namespace System.Cloud.Messaging;

public interface ISerializedMessagePayloadFeature<out T> where T : notnull
{
    T Payload { get; }
}
