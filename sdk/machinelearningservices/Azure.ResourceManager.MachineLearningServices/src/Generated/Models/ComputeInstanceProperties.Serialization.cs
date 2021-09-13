// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class ComputeInstanceProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(VmSize))
            {
                writer.WritePropertyName("vmSize");
                writer.WriteStringValue(VmSize);
            }
            if (Optional.IsDefined(Subnet))
            {
                writer.WritePropertyName("subnet");
                writer.WriteObjectValue(Subnet);
            }
            if (Optional.IsDefined(ApplicationSharingPolicy))
            {
                writer.WritePropertyName("applicationSharingPolicy");
                writer.WriteStringValue(ApplicationSharingPolicy.Value.ToString());
            }
            if (Optional.IsDefined(SshSettings))
            {
                writer.WritePropertyName("sshSettings");
                writer.WriteObjectValue(SshSettings);
            }
            if (Optional.IsDefined(ComputeInstanceAuthorizationType))
            {
                writer.WritePropertyName("computeInstanceAuthorizationType");
                writer.WriteStringValue(ComputeInstanceAuthorizationType.Value.ToString());
            }
            if (Optional.IsDefined(PersonalComputeInstanceSettings))
            {
                writer.WritePropertyName("personalComputeInstanceSettings");
                writer.WriteObjectValue(PersonalComputeInstanceSettings);
            }
            if (Optional.IsDefined(SetupScripts))
            {
                if (SetupScripts != null)
                {
                    writer.WritePropertyName("setupScripts");
                    writer.WriteObjectValue(SetupScripts);
                }
                else
                {
                    writer.WriteNull("setupScripts");
                }
            }
            if (Optional.IsDefined(Schedules))
            {
                writer.WritePropertyName("schedules");
                writer.WriteObjectValue(Schedules);
            }
            writer.WriteEndObject();
        }

        internal static ComputeInstanceProperties DeserializeComputeInstanceProperties(JsonElement element)
        {
            Optional<string> vmSize = default;
            Optional<ResourceId> subnet = default;
            Optional<ApplicationSharingPolicy> applicationSharingPolicy = default;
            Optional<ComputeInstanceSshSettings> sshSettings = default;
            Optional<ComputeInstanceConnectivityEndpoints> connectivityEndpoints = default;
            Optional<IReadOnlyList<ComputeInstanceApplication>> applications = default;
            Optional<ComputeInstanceCreatedBy> createdBy = default;
            Optional<IReadOnlyList<ErrorResponse>> errors = default;
            Optional<ComputeInstanceState> state = default;
            Optional<ComputeInstanceAuthorizationType> computeInstanceAuthorizationType = default;
            Optional<PersonalComputeInstanceSettings> personalComputeInstanceSettings = default;
            Optional<SetupScripts> setupScripts = default;
            Optional<ComputeInstanceLastOperation> lastOperation = default;
            Optional<ComputeSchedules> schedules = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmSize"))
                {
                    vmSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subnet"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    subnet = ResourceId.DeserializeResourceId(property.Value);
                    continue;
                }
                if (property.NameEquals("applicationSharingPolicy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    applicationSharingPolicy = new ApplicationSharingPolicy(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sshSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sshSettings = ComputeInstanceSshSettings.DeserializeComputeInstanceSshSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("connectivityEndpoints"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    connectivityEndpoints = ComputeInstanceConnectivityEndpoints.DeserializeComputeInstanceConnectivityEndpoints(property.Value);
                    continue;
                }
                if (property.NameEquals("applications"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ComputeInstanceApplication> array = new List<ComputeInstanceApplication>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ComputeInstanceApplication.DeserializeComputeInstanceApplication(item));
                    }
                    applications = array;
                    continue;
                }
                if (property.NameEquals("createdBy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    createdBy = ComputeInstanceCreatedBy.DeserializeComputeInstanceCreatedBy(property.Value);
                    continue;
                }
                if (property.NameEquals("errors"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ErrorResponse> array = new List<ErrorResponse>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<ErrorResponse>(item.ToString()));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("state"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    state = new ComputeInstanceState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("computeInstanceAuthorizationType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    computeInstanceAuthorizationType = new ComputeInstanceAuthorizationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("personalComputeInstanceSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    personalComputeInstanceSettings = PersonalComputeInstanceSettings.DeserializePersonalComputeInstanceSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("setupScripts"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        setupScripts = null;
                        continue;
                    }
                    setupScripts = SetupScripts.DeserializeSetupScripts(property.Value);
                    continue;
                }
                if (property.NameEquals("lastOperation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastOperation = ComputeInstanceLastOperation.DeserializeComputeInstanceLastOperation(property.Value);
                    continue;
                }
                if (property.NameEquals("schedules"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    schedules = ComputeSchedules.DeserializeComputeSchedules(property.Value);
                    continue;
                }
            }
            return new ComputeInstanceProperties(vmSize.Value, subnet.Value, Optional.ToNullable(applicationSharingPolicy), sshSettings.Value, connectivityEndpoints.Value, Optional.ToList(applications), createdBy.Value, Optional.ToList(errors), Optional.ToNullable(state), Optional.ToNullable(computeInstanceAuthorizationType), personalComputeInstanceSettings.Value, setupScripts.Value, lastOperation.Value, schedules.Value);
        }
    }
}
