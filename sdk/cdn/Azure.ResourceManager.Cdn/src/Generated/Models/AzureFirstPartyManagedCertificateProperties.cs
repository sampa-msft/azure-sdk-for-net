// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Azure FirstParty Managed Certificate provided by other first party resource providers to enable HTTPS. </summary>
    public partial class AzureFirstPartyManagedCertificateProperties : SecretProperties
    {
        /// <summary> Initializes a new instance of AzureFirstPartyManagedCertificateProperties. </summary>
        public AzureFirstPartyManagedCertificateProperties()
        {
            SecretType = SecretType.AzureFirstPartyManagedCertificate;
        }

        /// <summary> Initializes a new instance of AzureFirstPartyManagedCertificateProperties. </summary>
        /// <param name="secretType"> The type of the secret resource. </param>
        internal AzureFirstPartyManagedCertificateProperties(SecretType secretType) : base(secretType)
        {
            SecretType = secretType;
        }
    }
}
