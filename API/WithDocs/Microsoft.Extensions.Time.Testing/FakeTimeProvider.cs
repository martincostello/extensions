// Assembly 'Microsoft.Extensions.TimeProvider.Testing'

using System;
using System.Collections.Generic;
using System.Threading;

namespace Microsoft.Extensions.Time.Testing;

/// <summary>
/// A synthetic clock used to provide deterministic behavior in tests.
/// </summary>
public class FakeTimeProvider : TimeProvider
{
    /// <inheritdoc />
    public override TimeZoneInfo LocalTimeZone { get; }

    /// <summary>
    /// Gets the amount that the value from <see cref="M:Microsoft.Extensions.Time.Testing.FakeTimeProvider.GetTimestamp" /> increments per second.
    /// </summary>
    /// <remarks>
    /// We fix it here for test instability which would otherwise occur within
    /// <see cref="M:Microsoft.Extensions.Time.Testing.FakeTimeProvider.GetTimestamp" /> when the result of multiplying underlying ticks
    /// by frequency and dividing by ticks per second is truncated to long.
    ///
    /// Similarly truncation could occur when reversing this calculation to figure a time
    /// interval from the difference between two timestamps.
    ///
    /// As ticks per second is always 10^7, setting frequency to 10^7 is convenient.
    /// It happens that the system usually uses 10^9 or 10^6 so this could expose
    /// any assumption made that it is one of those values.
    /// </remarks>
    public override long TimestampFrequency { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:Microsoft.Extensions.Time.Testing.FakeTimeProvider" /> class.
    /// </summary>
    /// <remarks>
    /// This creates a clock whose time is set to midnight January 1st 2000.
    /// The clock is set to not automatically advance every time it is read.
    /// </remarks>
    public FakeTimeProvider();

    /// <summary>
    /// Initializes a new instance of the <see cref="T:Microsoft.Extensions.Time.Testing.FakeTimeProvider" /> class.
    /// </summary>
    /// <param name="startTime">The initial time reported by the clock.</param>
    public FakeTimeProvider(DateTimeOffset startTime);

    /// <inheritdoc />
    public override DateTimeOffset GetUtcNow();

    /// <summary>
    /// Sets the date and time in the UTC timezone.
    /// </summary>
    /// <param name="value">The date and time in the UTC timezone.</param>
    public void SetUtcNow(DateTimeOffset value);

    /// <summary>
    /// Advances the clock's time by a specific amount.
    /// </summary>
    /// <param name="delta">The amount of time to advance the clock by.</param>
    public void Advance(TimeSpan delta);

    /// <summary>
    /// Advances the clock's time by one millisecond.
    /// </summary>
    public void Advance();

    /// <inheritdoc />
    public override long GetTimestamp();

    /// <summary>
    /// Sets the local timezone.
    /// </summary>
    /// <param name="localTimeZone">The local timezone.</param>
    public void SetLocalTimeZone(TimeZoneInfo localTimeZone);

    /// <summary>
    /// Returns a string representation this clock's current time.
    /// </summary>
    /// <returns>A string representing the clock's current time.</returns>
    public override string ToString();

    /// <inheritdoc />
    public override ITimer CreateTimer(TimerCallback callback, object? state, TimeSpan dueTime, TimeSpan period);
}
