// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for OperatingSystemType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OperatingSystemType
    {
        [EnumMember(Value = "Windows")]
        Windows,
        [EnumMember(Value = "Linux")]
        Linux
    }
    internal static class OperatingSystemTypeEnumExtension
    {
        internal static string ToSerializedValue(this OperatingSystemType? value)
        {
            return value == null ? null : ((OperatingSystemType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this OperatingSystemType value)
        {
            switch( value )
            {
                case OperatingSystemType.Windows:
                    return "Windows";
                case OperatingSystemType.Linux:
                    return "Linux";
            }
            return null;
        }

        internal static OperatingSystemType? ParseOperatingSystemType(this string value)
        {
            switch( value )
            {
                case "Windows":
                    return OperatingSystemType.Windows;
                case "Linux":
                    return OperatingSystemType.Linux;
            }
            return null;
        }
    }
}
