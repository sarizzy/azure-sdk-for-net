// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Iot.Hub.Service.Models
{
    public partial class SymmetricKey : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (PrimaryKey != null)
            {
                writer.WritePropertyName("primaryKey");
                writer.WriteStringValue(PrimaryKey);
            }
            if (SecondaryKey != null)
            {
                writer.WritePropertyName("secondaryKey");
                writer.WriteStringValue(SecondaryKey);
            }
            writer.WriteEndObject();
        }

        internal static SymmetricKey DeserializeSymmetricKey(JsonElement element)
        {
            string primaryKey = default;
            string secondaryKey = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryKey"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryKey"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    secondaryKey = property.Value.GetString();
                    continue;
                }
            }
            return new SymmetricKey(primaryKey, secondaryKey);
        }
    }
}
