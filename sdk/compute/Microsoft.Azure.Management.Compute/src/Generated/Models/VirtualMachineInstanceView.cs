// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The instance view of a virtual machine.
    /// </summary>
    public partial class VirtualMachineInstanceView
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineInstanceView class.
        /// </summary>
        public VirtualMachineInstanceView()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineInstanceView class.
        /// </summary>
        /// <param name="platformUpdateDomain">Specifies the update domain of
        /// the virtual machine.</param>
        /// <param name="platformFaultDomain">Specifies the fault domain of the
        /// virtual machine.</param>
        /// <param name="computerName">The computer name assigned to the
        /// virtual machine.</param>
        /// <param name="osName">The Operating System running on the virtual
        /// machine.</param>
        /// <param name="osVersion">The version of Operating System running on
        /// the virtual machine.</param>
        /// <param name="hyperVGeneration">Specifies the HyperVGeneration Type
        /// associated with a resource. Possible values include: 'V1',
        /// 'V2'</param>
        /// <param name="rdpThumbPrint">The Remote desktop certificate
        /// thumbprint.</param>
        /// <param name="vmAgent">The VM Agent running on the virtual
        /// machine.</param>
        /// <param name="maintenanceRedeployStatus">The Maintenance Operation
        /// status on the virtual machine.</param>
        /// <param name="disks">The virtual machine disk information.</param>
        /// <param name="extensions">The extensions information.</param>
        /// <param name="bootDiagnostics">Boot Diagnostics is a debugging
        /// feature which allows you to view Console Output and Screenshot to
        /// diagnose VM status. &lt;br&gt;&lt;br&gt; You can easily view the
        /// output of your console log. &lt;br&gt;&lt;br&gt; Azure also enables
        /// you to see a screenshot of the VM from the hypervisor.</param>
        /// <param name="statuses">The resource status information.</param>
        public VirtualMachineInstanceView(int? platformUpdateDomain = default(int?), int? platformFaultDomain = default(int?), string computerName = default(string), string osName = default(string), string osVersion = default(string), string hyperVGeneration = default(string), string rdpThumbPrint = default(string), VirtualMachineAgentInstanceView vmAgent = default(VirtualMachineAgentInstanceView), MaintenanceRedeployStatus maintenanceRedeployStatus = default(MaintenanceRedeployStatus), IList<DiskInstanceView> disks = default(IList<DiskInstanceView>), IList<VirtualMachineExtensionInstanceView> extensions = default(IList<VirtualMachineExtensionInstanceView>), BootDiagnosticsInstanceView bootDiagnostics = default(BootDiagnosticsInstanceView), IList<InstanceViewStatus> statuses = default(IList<InstanceViewStatus>))
        {
            PlatformUpdateDomain = platformUpdateDomain;
            PlatformFaultDomain = platformFaultDomain;
            ComputerName = computerName;
            OsName = osName;
            OsVersion = osVersion;
            HyperVGeneration = hyperVGeneration;
            RdpThumbPrint = rdpThumbPrint;
            VmAgent = vmAgent;
            MaintenanceRedeployStatus = maintenanceRedeployStatus;
            Disks = disks;
            Extensions = extensions;
            BootDiagnostics = bootDiagnostics;
            Statuses = statuses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the update domain of the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "platformUpdateDomain")]
        public int? PlatformUpdateDomain { get; set; }

        /// <summary>
        /// Gets or sets specifies the fault domain of the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "platformFaultDomain")]
        public int? PlatformFaultDomain { get; set; }

        /// <summary>
        /// Gets or sets the computer name assigned to the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "computerName")]
        public string ComputerName { get; set; }

        /// <summary>
        /// Gets or sets the Operating System running on the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "osName")]
        public string OsName { get; set; }

        /// <summary>
        /// Gets or sets the version of Operating System running on the virtual
        /// machine.
        /// </summary>
        [JsonProperty(PropertyName = "osVersion")]
        public string OsVersion { get; set; }

        /// <summary>
        /// Gets or sets specifies the HyperVGeneration Type associated with a
        /// resource. Possible values include: 'V1', 'V2'
        /// </summary>
        [JsonProperty(PropertyName = "hyperVGeneration")]
        public string HyperVGeneration { get; set; }

        /// <summary>
        /// Gets or sets the Remote desktop certificate thumbprint.
        /// </summary>
        [JsonProperty(PropertyName = "rdpThumbPrint")]
        public string RdpThumbPrint { get; set; }

        /// <summary>
        /// Gets or sets the VM Agent running on the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "vmAgent")]
        public VirtualMachineAgentInstanceView VmAgent { get; set; }

        /// <summary>
        /// Gets or sets the Maintenance Operation status on the virtual
        /// machine.
        /// </summary>
        [JsonProperty(PropertyName = "maintenanceRedeployStatus")]
        public MaintenanceRedeployStatus MaintenanceRedeployStatus { get; set; }

        /// <summary>
        /// Gets or sets the virtual machine disk information.
        /// </summary>
        [JsonProperty(PropertyName = "disks")]
        public IList<DiskInstanceView> Disks { get; set; }

        /// <summary>
        /// Gets or sets the extensions information.
        /// </summary>
        [JsonProperty(PropertyName = "extensions")]
        public IList<VirtualMachineExtensionInstanceView> Extensions { get; set; }

        /// <summary>
        /// Gets or sets boot Diagnostics is a debugging feature which allows
        /// you to view Console Output and Screenshot to diagnose VM status.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; You can easily view the output
        /// of your console log. &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; Azure
        /// also enables you to see a screenshot of the VM from the hypervisor.
        /// </summary>
        [JsonProperty(PropertyName = "bootDiagnostics")]
        public BootDiagnosticsInstanceView BootDiagnostics { get; set; }

        /// <summary>
        /// Gets or sets the resource status information.
        /// </summary>
        [JsonProperty(PropertyName = "statuses")]
        public IList<InstanceViewStatus> Statuses { get; set; }

    }
}
