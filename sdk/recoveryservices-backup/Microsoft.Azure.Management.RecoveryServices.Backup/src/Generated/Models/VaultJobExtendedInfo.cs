// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Vault Job for CMK - has CMK specific info.
    /// </summary>
    public partial class VaultJobExtendedInfo
    {
        /// <summary>
        /// Initializes a new instance of the VaultJobExtendedInfo class.
        /// </summary>
        public VaultJobExtendedInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VaultJobExtendedInfo class.
        /// </summary>
        /// <param name="propertyBag">Job properties.</param>
        public VaultJobExtendedInfo(IDictionary<string, string> propertyBag = default(IDictionary<string, string>))
        {
            PropertyBag = propertyBag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets job properties.
        /// </summary>
        [JsonProperty(PropertyName = "propertyBag")]
        public IDictionary<string, string> PropertyBag { get; set; }

    }
}