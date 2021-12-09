// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Custom domain analysis. </summary>
    public partial class CustomHostnameAnalysisResult : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of CustomHostnameAnalysisResult. </summary>
        public CustomHostnameAnalysisResult()
        {
            CNameRecords = new ChangeTrackingList<string>();
            TxtRecords = new ChangeTrackingList<string>();
            ARecords = new ChangeTrackingList<string>();
            AlternateCNameRecords = new ChangeTrackingList<string>();
            AlternateTxtRecords = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of CustomHostnameAnalysisResult. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="isHostnameAlreadyVerified"> &lt;code&gt;true&lt;/code&gt; if hostname is already verified; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="customDomainVerificationTest"> DNS verification test result. </param>
        /// <param name="customDomainVerificationFailureInfo"> Raw failure information if DNS verification fails. </param>
        /// <param name="hasConflictOnScaleUnit"> &lt;code&gt;true&lt;/code&gt; if there is a conflict on a scale unit; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="hasConflictAcrossSubscription"> &lt;code&gt;true&lt;/code&gt; if there is a conflict across subscriptions; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="conflictingAppResourceId"> Name of the conflicting app on scale unit if it&apos;s within the same subscription. </param>
        /// <param name="cNameRecords"> CName records controller can see for this hostname. </param>
        /// <param name="txtRecords"> TXT records controller can see for this hostname. </param>
        /// <param name="aRecords"> A records controller can see for this hostname. </param>
        /// <param name="alternateCNameRecords"> Alternate CName records controller can see for this hostname. </param>
        /// <param name="alternateTxtRecords"> Alternate TXT records controller can see for this hostname. </param>
        internal CustomHostnameAnalysisResult(ResourceIdentifier id, string name, ResourceType type, string kind, bool? isHostnameAlreadyVerified, DnsVerificationTestResult? customDomainVerificationTest, ErrorEntity customDomainVerificationFailureInfo, bool? hasConflictOnScaleUnit, bool? hasConflictAcrossSubscription, string conflictingAppResourceId, IList<string> cNameRecords, IList<string> txtRecords, IList<string> aRecords, IList<string> alternateCNameRecords, IList<string> alternateTxtRecords) : base(id, name, type, kind)
        {
            IsHostnameAlreadyVerified = isHostnameAlreadyVerified;
            CustomDomainVerificationTest = customDomainVerificationTest;
            CustomDomainVerificationFailureInfo = customDomainVerificationFailureInfo;
            HasConflictOnScaleUnit = hasConflictOnScaleUnit;
            HasConflictAcrossSubscription = hasConflictAcrossSubscription;
            ConflictingAppResourceId = conflictingAppResourceId;
            CNameRecords = cNameRecords;
            TxtRecords = txtRecords;
            ARecords = aRecords;
            AlternateCNameRecords = alternateCNameRecords;
            AlternateTxtRecords = alternateTxtRecords;
        }

        /// <summary> &lt;code&gt;true&lt;/code&gt; if hostname is already verified; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsHostnameAlreadyVerified { get; }
        /// <summary> DNS verification test result. </summary>
        public DnsVerificationTestResult? CustomDomainVerificationTest { get; }
        /// <summary> Raw failure information if DNS verification fails. </summary>
        public ErrorEntity CustomDomainVerificationFailureInfo { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if there is a conflict on a scale unit; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? HasConflictOnScaleUnit { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if there is a conflict across subscriptions; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? HasConflictAcrossSubscription { get; }
        /// <summary> Name of the conflicting app on scale unit if it&apos;s within the same subscription. </summary>
        public string ConflictingAppResourceId { get; }
        /// <summary> CName records controller can see for this hostname. </summary>
        public IList<string> CNameRecords { get; }
        /// <summary> TXT records controller can see for this hostname. </summary>
        public IList<string> TxtRecords { get; }
        /// <summary> A records controller can see for this hostname. </summary>
        public IList<string> ARecords { get; }
        /// <summary> Alternate CName records controller can see for this hostname. </summary>
        public IList<string> AlternateCNameRecords { get; }
        /// <summary> Alternate TXT records controller can see for this hostname. </summary>
        public IList<string> AlternateTxtRecords { get; }
    }
}
