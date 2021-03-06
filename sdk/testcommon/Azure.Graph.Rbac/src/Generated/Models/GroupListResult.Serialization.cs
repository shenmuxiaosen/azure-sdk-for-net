// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Graph.Rbac.Models
{
    public partial class GroupListResult
    {
        internal static GroupListResult DeserializeGroupListResult(JsonElement element)
        {
            IReadOnlyList<ADGroup> value = default;
            string odataNextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ADGroup> array = new List<ADGroup>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(ADGroup.DeserializeADGroup(item));
                        }
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("odata.nextLink"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    odataNextLink = property.Value.GetString();
                    continue;
                }
            }
            return new GroupListResult(value, odataNextLink);
        }
    }
}
