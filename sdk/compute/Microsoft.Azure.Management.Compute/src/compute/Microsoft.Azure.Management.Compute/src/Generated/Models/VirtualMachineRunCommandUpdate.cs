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
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes a Virtual Machine run command.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VirtualMachineRunCommandUpdate : UpdateResource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineRunCommandUpdate
        /// class.
        /// </summary>
        public VirtualMachineRunCommandUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineRunCommandUpdate
        /// class.
        /// </summary>
        /// <param name="tags">Resource tags</param>
        /// <param name="source">The source of the run command script.</param>
        /// <param name="parameters">The parameters used by the script.</param>
        /// <param name="protectedParameters">The parameters used by the
        /// script.</param>
        /// <param name="asyncExecution">Optional. If set to true, provisioning
        /// will complete as soon as the script starts and will not wait for
        /// script to complete.</param>
        /// <param name="runAsUser">Specifies the user account on the VM when
        /// executing the run command.</param>
        /// <param name="runAsPassword">Specifies the user account password on
        /// the VM when executing the run command.</param>
        /// <param name="timeoutInSeconds">The timeout in seconds to execute
        /// the run command.</param>
        /// <param name="outputBlobUri">Specifies the Azure storage blob where
        /// script output stream will be uploaded.</param>
        /// <param name="errorBlobUri">Specifies the Azure storage blob where
        /// script error stream will be uploaded.</param>
        /// <param name="provisioningState">The provisioning state, which only
        /// appears in the response.</param>
        /// <param name="instanceView">The virtual machine run command instance
        /// view.</param>
        public VirtualMachineRunCommandUpdate(IDictionary<string, string> tags = default(IDictionary<string, string>), VirtualMachineRunCommandScriptSource source = default(VirtualMachineRunCommandScriptSource), IList<RunCommandInputParameter> parameters = default(IList<RunCommandInputParameter>), IList<RunCommandInputParameter> protectedParameters = default(IList<RunCommandInputParameter>), bool? asyncExecution = default(bool?), string runAsUser = default(string), string runAsPassword = default(string), int? timeoutInSeconds = default(int?), string outputBlobUri = default(string), string errorBlobUri = default(string), string provisioningState = default(string), VirtualMachineRunCommandInstanceView instanceView = default(VirtualMachineRunCommandInstanceView))
            : base(tags)
        {
            Source = source;
            Parameters = parameters;
            ProtectedParameters = protectedParameters;
            AsyncExecution = asyncExecution;
            RunAsUser = runAsUser;
            RunAsPassword = runAsPassword;
            TimeoutInSeconds = timeoutInSeconds;
            OutputBlobUri = outputBlobUri;
            ErrorBlobUri = errorBlobUri;
            ProvisioningState = provisioningState;
            InstanceView = instanceView;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the source of the run command script.
        /// </summary>
        [JsonProperty(PropertyName = "properties.source")]
        public VirtualMachineRunCommandScriptSource Source { get; set; }

        /// <summary>
        /// Gets or sets the parameters used by the script.
        /// </summary>
        [JsonProperty(PropertyName = "properties.parameters")]
        public IList<RunCommandInputParameter> Parameters { get; set; }

        /// <summary>
        /// Gets or sets the parameters used by the script.
        /// </summary>
        [JsonProperty(PropertyName = "properties.protectedParameters")]
        public IList<RunCommandInputParameter> ProtectedParameters { get; set; }

        /// <summary>
        /// Gets or sets optional. If set to true, provisioning will complete
        /// as soon as the script starts and will not wait for script to
        /// complete.
        /// </summary>
        [JsonProperty(PropertyName = "properties.asyncExecution")]
        public bool? AsyncExecution { get; set; }

        /// <summary>
        /// Gets or sets specifies the user account on the VM when executing
        /// the run command.
        /// </summary>
        [JsonProperty(PropertyName = "properties.runAsUser")]
        public string RunAsUser { get; set; }

        /// <summary>
        /// Gets or sets specifies the user account password on the VM when
        /// executing the run command.
        /// </summary>
        [JsonProperty(PropertyName = "properties.runAsPassword")]
        public string RunAsPassword { get; set; }

        /// <summary>
        /// Gets or sets the timeout in seconds to execute the run command.
        /// </summary>
        [JsonProperty(PropertyName = "properties.timeoutInSeconds")]
        public int? TimeoutInSeconds { get; set; }

        /// <summary>
        /// Gets or sets specifies the Azure storage blob where script output
        /// stream will be uploaded.
        /// </summary>
        [JsonProperty(PropertyName = "properties.outputBlobUri")]
        public string OutputBlobUri { get; set; }

        /// <summary>
        /// Gets or sets specifies the Azure storage blob where script error
        /// stream will be uploaded.
        /// </summary>
        [JsonProperty(PropertyName = "properties.errorBlobUri")]
        public string ErrorBlobUri { get; set; }

        /// <summary>
        /// Gets the provisioning state, which only appears in the response.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the virtual machine run command instance view.
        /// </summary>
        [JsonProperty(PropertyName = "properties.instanceView")]
        public VirtualMachineRunCommandInstanceView InstanceView { get; private set; }

    }
}
