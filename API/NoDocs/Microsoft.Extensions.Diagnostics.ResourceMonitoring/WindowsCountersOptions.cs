// Assembly 'Microsoft.Extensions.Diagnostics.ResourceMonitoring'

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Microsoft.Shared.Data.Validation;

namespace Microsoft.Extensions.Diagnostics.ResourceMonitoring;

[System.Diagnostics.CodeAnalysis.Experimental]
public class WindowsCountersOptions
{
    [Required]
    public ISet<string> InstanceIpAddresses { get; set; }
    [System.Diagnostics.CodeAnalysis.Experimental]
    [TimeSpan(100, 900000)]
    public TimeSpan CachingInterval { get; set; }
    public WindowsCountersOptions();
}
