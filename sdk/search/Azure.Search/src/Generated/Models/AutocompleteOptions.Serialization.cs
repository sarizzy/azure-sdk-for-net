// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search
{
    public partial class AutocompleteOptions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("search");
            writer.WriteStringValue(SearchText);
            if (Mode != null)
            {
                writer.WritePropertyName("autocompleteMode");
                writer.WriteStringValue(Mode.Value.ToSerialString());
            }
            if (Filter != null)
            {
                writer.WritePropertyName("filter");
                writer.WriteStringValue(Filter);
            }
            if (UseFuzzyMatching != null)
            {
                writer.WritePropertyName("fuzzy");
                writer.WriteBooleanValue(UseFuzzyMatching.Value);
            }
            if (HighlightPostTag != null)
            {
                writer.WritePropertyName("highlightPostTag");
                writer.WriteStringValue(HighlightPostTag);
            }
            if (HighlightPreTag != null)
            {
                writer.WritePropertyName("highlightPreTag");
                writer.WriteStringValue(HighlightPreTag);
            }
            if (MinimumCoverage != null)
            {
                writer.WritePropertyName("minimumCoverage");
                writer.WriteNumberValue(MinimumCoverage.Value);
            }
            if (SearchFieldsRaw != null)
            {
                writer.WritePropertyName("searchFields");
                writer.WriteStringValue(SearchFieldsRaw);
            }
            writer.WritePropertyName("suggesterName");
            writer.WriteStringValue(SuggesterName);
            if (Size != null)
            {
                writer.WritePropertyName("top");
                writer.WriteNumberValue(Size.Value);
            }
            writer.WriteEndObject();
        }
        internal static AutocompleteOptions DeserializeAutocompleteOptions(JsonElement element)
        {
            AutocompleteOptions result = new AutocompleteOptions();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("search"))
                {
                    result.SearchText = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("autocompleteMode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Mode = property.Value.GetString().ToAutocompleteMode();
                    continue;
                }
                if (property.NameEquals("filter"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Filter = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fuzzy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.UseFuzzyMatching = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("highlightPostTag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.HighlightPostTag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("highlightPreTag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.HighlightPreTag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("minimumCoverage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.MinimumCoverage = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("searchFields"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.SearchFieldsRaw = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("suggesterName"))
                {
                    result.SuggesterName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("top"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Size = property.Value.GetInt32();
                    continue;
                }
            }
            return result;
        }
    }
}
