// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Iot.TimeSeriesInsights.Models
{
    public partial class InstancesSearchStringSuggestion
    {
        internal static InstancesSearchStringSuggestion DeserializeInstancesSearchStringSuggestion(JsonElement element)
        {
            Optional<string> searchString = default;
            Optional<string> highlightedSearchString = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("searchString"))
                {
                    searchString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("highlightedSearchString"))
                {
                    highlightedSearchString = property.Value.GetString();
                    continue;
                }
            }
            return new InstancesSearchStringSuggestion(searchString.Value, highlightedSearchString.Value);
        }
    }
}