// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AutoManage.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Automanage configuration profile preference properties.
    /// </summary>
    public partial class ConfigurationProfilePreferenceProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ConfigurationProfilePreferenceProperties class.
        /// </summary>
        public ConfigurationProfilePreferenceProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ConfigurationProfilePreferenceProperties class.
        /// </summary>
        /// <param name="vmBackup">The custom preferences for Azure VM
        /// Backup.</param>
        /// <param name="antiMalware">The custom preferences for Azure
        /// Antimalware.</param>
        public ConfigurationProfilePreferenceProperties(ConfigurationProfilePreferenceVmBackup vmBackup = default(ConfigurationProfilePreferenceVmBackup), ConfigurationProfilePreferenceAntiMalware antiMalware = default(ConfigurationProfilePreferenceAntiMalware))
        {
            VmBackup = vmBackup;
            AntiMalware = antiMalware;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the custom preferences for Azure VM Backup.
        /// </summary>
        [JsonProperty(PropertyName = "vmBackup")]
        public ConfigurationProfilePreferenceVmBackup VmBackup { get; set; }

        /// <summary>
        /// Gets or sets the custom preferences for Azure Antimalware.
        /// </summary>
        [JsonProperty(PropertyName = "antiMalware")]
        public ConfigurationProfilePreferenceAntiMalware AntiMalware { get; set; }

    }
}
