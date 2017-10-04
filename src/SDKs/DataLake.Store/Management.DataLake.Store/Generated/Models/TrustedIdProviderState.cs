// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataLake;
    using Microsoft.Azure.Management.DataLake.Store;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for TrustedIdProviderState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TrustedIdProviderState
    {
        [EnumMember(Value = "Enabled")]
        Enabled,
        [EnumMember(Value = "Disabled")]
        Disabled
    }
    internal static class TrustedIdProviderStateEnumExtension
    {
        internal static string ToSerializedValue(this TrustedIdProviderState? value)  =>
            value == null ? null : ((TrustedIdProviderState)value).ToSerializedValue();

        internal static string ToSerializedValue(this TrustedIdProviderState value)
        {
            switch( value )
            {
                case TrustedIdProviderState.Enabled:
                    return "Enabled";
                case TrustedIdProviderState.Disabled:
                    return "Disabled";
            }
            return null;
        }

        internal static TrustedIdProviderState? ParseTrustedIdProviderState(this string value)
        {
            switch( value )
            {
                case "Enabled":
                    return TrustedIdProviderState.Enabled;
                case "Disabled":
                    return TrustedIdProviderState.Disabled;
            }
            return null;
        }
    }
}