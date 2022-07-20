// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ContainerService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerService
{
    public partial class AgentPoolData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Count))
            {
                writer.WritePropertyName("count");
                writer.WriteNumberValue(Count.Value);
            }
            if (Optional.IsDefined(VmSize))
            {
                writer.WritePropertyName("vmSize");
                writer.WriteStringValue(VmSize);
            }
            if (Optional.IsDefined(OSDiskSizeGB))
            {
                writer.WritePropertyName("osDiskSizeGB");
                writer.WriteNumberValue(OSDiskSizeGB.Value);
            }
            if (Optional.IsDefined(OSDiskType))
            {
                writer.WritePropertyName("osDiskType");
                writer.WriteStringValue(OSDiskType.Value.ToString());
            }
            if (Optional.IsDefined(KubeletDiskType))
            {
                writer.WritePropertyName("kubeletDiskType");
                writer.WriteStringValue(KubeletDiskType.Value.ToString());
            }
            if (Optional.IsDefined(WorkloadRuntime))
            {
                writer.WritePropertyName("workloadRuntime");
                writer.WriteStringValue(WorkloadRuntime.Value.ToString());
            }
            if (Optional.IsDefined(VnetSubnetId))
            {
                writer.WritePropertyName("vnetSubnetID");
                writer.WriteStringValue(VnetSubnetId);
            }
            if (Optional.IsDefined(PodSubnetId))
            {
                writer.WritePropertyName("podSubnetID");
                writer.WriteStringValue(PodSubnetId);
            }
            if (Optional.IsDefined(MaxPods))
            {
                writer.WritePropertyName("maxPods");
                writer.WriteNumberValue(MaxPods.Value);
            }
            if (Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType");
                writer.WriteStringValue(OSType.Value.ToString());
            }
            if (Optional.IsDefined(OSSKU))
            {
                writer.WritePropertyName("osSKU");
                writer.WriteStringValue(OSSKU.Value.ToString());
            }
            if (Optional.IsDefined(MaxCount))
            {
                writer.WritePropertyName("maxCount");
                writer.WriteNumberValue(MaxCount.Value);
            }
            if (Optional.IsDefined(MinCount))
            {
                writer.WritePropertyName("minCount");
                writer.WriteNumberValue(MinCount.Value);
            }
            if (Optional.IsDefined(EnableAutoScaling))
            {
                writer.WritePropertyName("enableAutoScaling");
                writer.WriteBooleanValue(EnableAutoScaling.Value);
            }
            if (Optional.IsDefined(ScaleDownMode))
            {
                writer.WritePropertyName("scaleDownMode");
                writer.WriteStringValue(ScaleDownMode.Value.ToString());
            }
            if (Optional.IsDefined(TypePropertiesType))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(TypePropertiesType.Value.ToString());
            }
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode");
                writer.WriteStringValue(Mode.Value.ToString());
            }
            if (Optional.IsDefined(OrchestratorVersion))
            {
                writer.WritePropertyName("orchestratorVersion");
                writer.WriteStringValue(OrchestratorVersion);
            }
            if (Optional.IsDefined(UpgradeSettings))
            {
                writer.WritePropertyName("upgradeSettings");
                writer.WriteObjectValue(UpgradeSettings);
            }
            if (Optional.IsDefined(PowerState))
            {
                writer.WritePropertyName("powerState");
                writer.WriteObjectValue(PowerState);
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
            if (Optional.IsDefined(EnableNodePublicIP))
            {
                writer.WritePropertyName("enableNodePublicIP");
                writer.WriteBooleanValue(EnableNodePublicIP.Value);
            }
            if (Optional.IsDefined(NodePublicIPPrefixId))
            {
                writer.WritePropertyName("nodePublicIPPrefixID");
                writer.WriteStringValue(NodePublicIPPrefixId);
            }
            if (Optional.IsDefined(ScaleSetPriority))
            {
                writer.WritePropertyName("scaleSetPriority");
                writer.WriteStringValue(ScaleSetPriority.Value.ToString());
            }
            if (Optional.IsDefined(ScaleSetEvictionPolicy))
            {
                writer.WritePropertyName("scaleSetEvictionPolicy");
                writer.WriteStringValue(ScaleSetEvictionPolicy.Value.ToString());
            }
            if (Optional.IsDefined(SpotMaxPrice))
            {
                writer.WritePropertyName("spotMaxPrice");
                writer.WriteNumberValue(SpotMaxPrice.Value);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(NodeLabels))
            {
                writer.WritePropertyName("nodeLabels");
                writer.WriteStartObject();
                foreach (var item in NodeLabels)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(NodeTaints))
            {
                writer.WritePropertyName("nodeTaints");
                writer.WriteStartArray();
                foreach (var item in NodeTaints)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ProximityPlacementGroupId))
            {
                writer.WritePropertyName("proximityPlacementGroupID");
                writer.WriteStringValue(ProximityPlacementGroupId);
            }
            if (Optional.IsDefined(KubeletConfig))
            {
                writer.WritePropertyName("kubeletConfig");
                writer.WriteObjectValue(KubeletConfig);
            }
            if (Optional.IsDefined(LinuxOSConfig))
            {
                writer.WritePropertyName("linuxOSConfig");
                writer.WriteObjectValue(LinuxOSConfig);
            }
            if (Optional.IsDefined(EnableEncryptionAtHost))
            {
                writer.WritePropertyName("enableEncryptionAtHost");
                writer.WriteBooleanValue(EnableEncryptionAtHost.Value);
            }
            if (Optional.IsDefined(EnableUltraSSD))
            {
                writer.WritePropertyName("enableUltraSSD");
                writer.WriteBooleanValue(EnableUltraSSD.Value);
            }
            if (Optional.IsDefined(EnableFips))
            {
                writer.WritePropertyName("enableFIPS");
                writer.WriteBooleanValue(EnableFips.Value);
            }
            if (Optional.IsDefined(GpuInstanceProfile))
            {
                writer.WritePropertyName("gpuInstanceProfile");
                writer.WriteStringValue(GpuInstanceProfile.Value.ToString());
            }
            if (Optional.IsDefined(CreationData))
            {
                writer.WritePropertyName("creationData");
                writer.WriteObjectValue(CreationData);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AgentPoolData DeserializeAgentPoolData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<int> count = default;
            Optional<string> vmSize = default;
            Optional<int> osDiskSizeGB = default;
            Optional<OSDiskType> osDiskType = default;
            Optional<KubeletDiskType> kubeletDiskType = default;
            Optional<WorkloadRuntime> workloadRuntime = default;
            Optional<string> vnetSubnetId = default;
            Optional<string> podSubnetId = default;
            Optional<int> maxPods = default;
            Optional<OSType> osType = default;
            Optional<Ossku> ossku = default;
            Optional<int> maxCount = default;
            Optional<int> minCount = default;
            Optional<bool> enableAutoScaling = default;
            Optional<ScaleDownMode> scaleDownMode = default;
            Optional<AgentPoolType> type0 = default;
            Optional<AgentPoolMode> mode = default;
            Optional<string> orchestratorVersion = default;
            Optional<string> currentOrchestratorVersion = default;
            Optional<string> nodeImageVersion = default;
            Optional<AgentPoolUpgradeSettings> upgradeSettings = default;
            Optional<string> provisioningState = default;
            Optional<PowerState> powerState = default;
            Optional<IList<string>> availabilityZones = default;
            Optional<bool> enableNodePublicIP = default;
            Optional<string> nodePublicIPPrefixId = default;
            Optional<ScaleSetPriority> scaleSetPriority = default;
            Optional<ScaleSetEvictionPolicy> scaleSetEvictionPolicy = default;
            Optional<float> spotMaxPrice = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<IDictionary<string, string>> nodeLabels = default;
            Optional<IList<string>> nodeTaints = default;
            Optional<string> proximityPlacementGroupId = default;
            Optional<KubeletConfig> kubeletConfig = default;
            Optional<LinuxOSConfig> linuxOSConfig = default;
            Optional<bool> enableEncryptionAtHost = default;
            Optional<bool> enableUltraSSD = default;
            Optional<bool> enableFIPS = default;
            Optional<GPUInstanceProfile> gpuInstanceProfile = default;
            Optional<CreationData> creationData = default;
            foreach (var property in element.EnumerateObject())
            {
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
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
                        if (property0.NameEquals("count"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            count = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("vmSize"))
                        {
                            vmSize = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("osDiskSizeGB"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            osDiskSizeGB = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("osDiskType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            osDiskType = new OSDiskType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("kubeletDiskType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            kubeletDiskType = new KubeletDiskType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("workloadRuntime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            workloadRuntime = new WorkloadRuntime(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("vnetSubnetID"))
                        {
                            vnetSubnetId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("podSubnetID"))
                        {
                            podSubnetId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("maxPods"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            maxPods = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("osType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            osType = new OSType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("osSKU"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            ossku = new Ossku(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("maxCount"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            maxCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("minCount"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            minCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("enableAutoScaling"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enableAutoScaling = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("scaleDownMode"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            scaleDownMode = new ScaleDownMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("type"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            type0 = new AgentPoolType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("mode"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            mode = new AgentPoolMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("orchestratorVersion"))
                        {
                            orchestratorVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("currentOrchestratorVersion"))
                        {
                            currentOrchestratorVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nodeImageVersion"))
                        {
                            nodeImageVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("upgradeSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            upgradeSettings = AgentPoolUpgradeSettings.DeserializeAgentPoolUpgradeSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("powerState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            powerState = PowerState.DeserializePowerState(property0.Value);
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
                        if (property0.NameEquals("enableNodePublicIP"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enableNodePublicIP = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("nodePublicIPPrefixID"))
                        {
                            nodePublicIPPrefixId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("scaleSetPriority"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            scaleSetPriority = new ScaleSetPriority(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("scaleSetEvictionPolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            scaleSetEvictionPolicy = new ScaleSetEvictionPolicy(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("spotMaxPrice"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            spotMaxPrice = property0.Value.GetSingle();
                            continue;
                        }
                        if (property0.NameEquals("tags"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            tags = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("nodeLabels"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            nodeLabels = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("nodeTaints"))
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
                            nodeTaints = array;
                            continue;
                        }
                        if (property0.NameEquals("proximityPlacementGroupID"))
                        {
                            proximityPlacementGroupId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("kubeletConfig"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            kubeletConfig = KubeletConfig.DeserializeKubeletConfig(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("linuxOSConfig"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            linuxOSConfig = LinuxOSConfig.DeserializeLinuxOSConfig(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("enableEncryptionAtHost"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enableEncryptionAtHost = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableUltraSSD"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enableUltraSSD = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableFIPS"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enableFIPS = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("gpuInstanceProfile"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            gpuInstanceProfile = new GPUInstanceProfile(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("creationData"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            creationData = CreationData.DeserializeCreationData(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AgentPoolData(id, name, type, systemData.Value, Optional.ToNullable(count), vmSize.Value, Optional.ToNullable(osDiskSizeGB), Optional.ToNullable(osDiskType), Optional.ToNullable(kubeletDiskType), Optional.ToNullable(workloadRuntime), vnetSubnetId.Value, podSubnetId.Value, Optional.ToNullable(maxPods), Optional.ToNullable(osType), Optional.ToNullable(ossku), Optional.ToNullable(maxCount), Optional.ToNullable(minCount), Optional.ToNullable(enableAutoScaling), Optional.ToNullable(scaleDownMode), Optional.ToNullable(type0), Optional.ToNullable(mode), orchestratorVersion.Value, currentOrchestratorVersion.Value, nodeImageVersion.Value, upgradeSettings.Value, provisioningState.Value, powerState.Value, Optional.ToList(availabilityZones), Optional.ToNullable(enableNodePublicIP), nodePublicIPPrefixId.Value, Optional.ToNullable(scaleSetPriority), Optional.ToNullable(scaleSetEvictionPolicy), Optional.ToNullable(spotMaxPrice), Optional.ToDictionary(tags), Optional.ToDictionary(nodeLabels), Optional.ToList(nodeTaints), proximityPlacementGroupId.Value, kubeletConfig.Value, linuxOSConfig.Value, Optional.ToNullable(enableEncryptionAtHost), Optional.ToNullable(enableUltraSSD), Optional.ToNullable(enableFIPS), Optional.ToNullable(gpuInstanceProfile), creationData.Value);
        }
    }
}
