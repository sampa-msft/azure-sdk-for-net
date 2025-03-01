// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class SiteLogsConfigData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ApplicationLogs))
            {
                writer.WritePropertyName("applicationLogs");
                writer.WriteObjectValue(ApplicationLogs);
            }
            if (Optional.IsDefined(HttpLogs))
            {
                writer.WritePropertyName("httpLogs");
                writer.WriteObjectValue(HttpLogs);
            }
            if (Optional.IsDefined(FailedRequestsTracing))
            {
                writer.WritePropertyName("failedRequestsTracing");
                writer.WriteObjectValue(FailedRequestsTracing);
            }
            if (Optional.IsDefined(DetailedErrorMessages))
            {
                writer.WritePropertyName("detailedErrorMessages");
                writer.WriteObjectValue(DetailedErrorMessages);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SiteLogsConfigData DeserializeSiteLogsConfigData(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<ApplicationLogsConfig> applicationLogs = default;
            Optional<HttpLogsConfig> httpLogs = default;
            Optional<EnabledConfig> failedRequestsTracing = default;
            Optional<EnabledConfig> detailedErrorMessages = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
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
                        if (property0.NameEquals("applicationLogs"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            applicationLogs = ApplicationLogsConfig.DeserializeApplicationLogsConfig(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("httpLogs"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            httpLogs = HttpLogsConfig.DeserializeHttpLogsConfig(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("failedRequestsTracing"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            failedRequestsTracing = EnabledConfig.DeserializeEnabledConfig(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("detailedErrorMessages"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            detailedErrorMessages = EnabledConfig.DeserializeEnabledConfig(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SiteLogsConfigData(id, name, type, systemData, kind.Value, applicationLogs.Value, httpLogs.Value, failedRequestsTracing.Value, detailedErrorMessages.Value);
        }
    }
}
