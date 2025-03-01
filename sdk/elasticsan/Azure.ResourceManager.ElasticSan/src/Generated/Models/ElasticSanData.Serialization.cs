// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ElasticSan.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ElasticSan
{
    public partial class ElasticSanData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("tags");
            writer.WriteStartObject();
            foreach (var item in Tags)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsCollectionDefined(AvailabilityZones))
            {
                writer.WritePropertyName("availabilityZones");
                writer.WriteStartArray();
                foreach (var item in AvailabilityZones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(BaseSizeTiB))
            {
                writer.WritePropertyName("baseSizeTiB");
                writer.WriteNumberValue(BaseSizeTiB.Value);
            }
            if (Optional.IsDefined(ExtendedCapacitySizeTiB))
            {
                writer.WritePropertyName("extendedCapacitySizeTiB");
                writer.WriteNumberValue(ExtendedCapacitySizeTiB.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ElasticSanData DeserializeElasticSanData(JsonElement element)
        {
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<ElasticSanSku> sku = default;
            Optional<IList<string>> availabilityZones = default;
            Optional<ProvisioningStates> provisioningState = default;
            Optional<long> baseSizeTiB = default;
            Optional<long> extendedCapacitySizeTiB = default;
            Optional<long> totalVolumeSizeGiB = default;
            Optional<long> volumeGroupCount = default;
            Optional<long> totalIops = default;
            Optional<long> totalMBps = default;
            Optional<long> provisionedMBps = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("sku"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sku = ElasticSanSku.DeserializeElasticSanSku(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("availabilityZones"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            availabilityZones = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningStates(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("baseSizeTiB"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            baseSizeTiB = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("extendedCapacitySizeTiB"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            extendedCapacitySizeTiB = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("totalVolumeSizeGiB"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            totalVolumeSizeGiB = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("volumeGroupCount"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            volumeGroupCount = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("totalIops"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            totalIops = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("totalMBps"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            totalMBps = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("provisionedMBps"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisionedMBps = property0.Value.GetInt64();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ElasticSanData(id, name, type, systemData, tags, location, sku.Value, Optional.ToList(availabilityZones), Optional.ToNullable(provisioningState), Optional.ToNullable(baseSizeTiB), Optional.ToNullable(extendedCapacitySizeTiB), Optional.ToNullable(totalVolumeSizeGiB), Optional.ToNullable(volumeGroupCount), Optional.ToNullable(totalIops), Optional.ToNullable(totalMBps), Optional.ToNullable(provisionedMBps));
        }
    }
}
