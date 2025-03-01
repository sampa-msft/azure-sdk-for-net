// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ElasticSan.Models
{
    public partial class ElasticSanVolumeTierInfo
    {
        internal static ElasticSanVolumeTierInfo DeserializeElasticSanVolumeTierInfo(JsonElement element)
        {
            Optional<long> maxSizeGiB = default;
            Optional<long> minSizeGiB = default;
            Optional<long> minIncrementSizeGiB = default;
            Optional<long> maxIopsPerGiB = default;
            Optional<long> maxMBpsPerGiB = default;
            Optional<long> maxIops = default;
            Optional<long> maxMBps = default;
            Optional<long> maxConnectedClientCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxSizeGiB"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxSizeGiB = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("minSizeGiB"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    minSizeGiB = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("minIncrementSizeGiB"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    minIncrementSizeGiB = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("maxIopsPerGiB"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxIopsPerGiB = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("maxMBpsPerGiB"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxMBpsPerGiB = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("maxIops"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxIops = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("maxMBps"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxMBps = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("maxConnectedClientCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxConnectedClientCount = property.Value.GetInt64();
                    continue;
                }
            }
            return new ElasticSanVolumeTierInfo(Optional.ToNullable(maxSizeGiB), Optional.ToNullable(minSizeGiB), Optional.ToNullable(minIncrementSizeGiB), Optional.ToNullable(maxIopsPerGiB), Optional.ToNullable(maxMBpsPerGiB), Optional.ToNullable(maxIops), Optional.ToNullable(maxMBps), Optional.ToNullable(maxConnectedClientCount));
        }
    }
}
