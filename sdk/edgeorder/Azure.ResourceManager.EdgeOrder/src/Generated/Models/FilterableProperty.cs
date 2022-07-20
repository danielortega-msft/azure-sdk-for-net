// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Different types of filters supported and its values. </summary>
    public partial class FilterableProperty
    {
        /// <summary> Initializes a new instance of FilterableProperty. </summary>
        /// <param name="supportedFilterType"> Type of product filter. </param>
        /// <param name="supportedValues"> Values to be filtered. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="supportedValues"/> is null. </exception>
        public FilterableProperty(SupportedFilterType supportedFilterType, IEnumerable<string> supportedValues)
        {
            if (supportedValues == null)
            {
                throw new ArgumentNullException(nameof(supportedValues));
            }

            SupportedFilterType = supportedFilterType;
            SupportedValues = supportedValues.ToList();
        }

        /// <summary> Initializes a new instance of FilterableProperty. </summary>
        /// <param name="supportedFilterType"> Type of product filter. </param>
        /// <param name="supportedValues"> Values to be filtered. </param>
        internal FilterableProperty(SupportedFilterType supportedFilterType, IList<string> supportedValues)
        {
            SupportedFilterType = supportedFilterType;
            SupportedValues = supportedValues;
        }

        /// <summary> Type of product filter. </summary>
        public SupportedFilterType SupportedFilterType { get; set; }
        /// <summary> Values to be filtered. </summary>
        public IList<string> SupportedValues { get; }
    }
}
