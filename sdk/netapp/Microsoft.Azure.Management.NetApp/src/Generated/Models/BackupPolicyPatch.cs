// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.NetApp.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Backup policy Details for create and update
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class BackupPolicyPatch
    {
        /// <summary>
        /// Initializes a new instance of the BackupPolicyPatch class.
        /// </summary>
        public BackupPolicyPatch()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BackupPolicyPatch class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="name">Name of backup policy</param>
        /// <param name="provisioningState">Azure lifecycle management</param>
        /// <param name="dailyBackupsToKeep">Daily backups count to
        /// keep</param>
        /// <param name="weeklyBackupsToKeep">Weekly backups count to
        /// keep</param>
        /// <param name="monthlyBackupsToKeep">Monthly backups count to
        /// keep</param>
        /// <param name="yearlyBackupsToKeep">Yearly backups count to
        /// keep</param>
        /// <param name="volumesAssigned">Volumes using current backup
        /// policy</param>
        /// <param name="enabled">The property to decide policy is enabled or
        /// not</param>
        /// <param name="volumeBackups">A list of volumes assigned to this
        /// policy</param>
        public BackupPolicyPatch(string location = default(string), string name = default(string), string provisioningState = default(string), int? dailyBackupsToKeep = default(int?), int? weeklyBackupsToKeep = default(int?), int? monthlyBackupsToKeep = default(int?), int? yearlyBackupsToKeep = default(int?), int? volumesAssigned = default(int?), bool? enabled = default(bool?), IList<VolumeBackups> volumeBackups = default(IList<VolumeBackups>))
        {
            Location = location;
            Name = name;
            ProvisioningState = provisioningState;
            DailyBackupsToKeep = dailyBackupsToKeep;
            WeeklyBackupsToKeep = weeklyBackupsToKeep;
            MonthlyBackupsToKeep = monthlyBackupsToKeep;
            YearlyBackupsToKeep = yearlyBackupsToKeep;
            VolumesAssigned = volumesAssigned;
            Enabled = enabled;
            VolumeBackups = volumeBackups;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource location
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets name of backup policy
        /// </summary>
        [JsonProperty(PropertyName = "properties.name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets azure lifecycle management
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets daily backups count to keep
        /// </summary>
        [JsonProperty(PropertyName = "properties.dailyBackupsToKeep")]
        public int? DailyBackupsToKeep { get; set; }

        /// <summary>
        /// Gets or sets weekly backups count to keep
        /// </summary>
        [JsonProperty(PropertyName = "properties.weeklyBackupsToKeep")]
        public int? WeeklyBackupsToKeep { get; set; }

        /// <summary>
        /// Gets or sets monthly backups count to keep
        /// </summary>
        [JsonProperty(PropertyName = "properties.monthlyBackupsToKeep")]
        public int? MonthlyBackupsToKeep { get; set; }

        /// <summary>
        /// Gets or sets yearly backups count to keep
        /// </summary>
        [JsonProperty(PropertyName = "properties.yearlyBackupsToKeep")]
        public int? YearlyBackupsToKeep { get; set; }

        /// <summary>
        /// Gets or sets volumes using current backup policy
        /// </summary>
        [JsonProperty(PropertyName = "properties.volumesAssigned")]
        public int? VolumesAssigned { get; set; }

        /// <summary>
        /// Gets or sets the property to decide policy is enabled or not
        /// </summary>
        [JsonProperty(PropertyName = "properties.enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets a list of volumes assigned to this policy
        /// </summary>
        [JsonProperty(PropertyName = "properties.volumeBackups")]
        public IList<VolumeBackups> VolumeBackups { get; set; }

    }
}