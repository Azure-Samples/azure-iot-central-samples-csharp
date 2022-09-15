// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.IoTCentral.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The file upload configuration definition.
    /// </summary>
    public partial class FileUpload
    {
        /// <summary>
        /// Initializes a new instance of the FileUpload class.
        /// </summary>
        public FileUpload()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FileUpload class.
        /// </summary>
        /// <param name="connectionString">The connection string used to
        /// configure the storage account</param>
        /// <param name="container">The name of the container inside the
        /// storage account</param>
        /// <param name="account">The storage account name where to upload the
        /// file to</param>
        /// <param name="sasTtl">ISO 8601 duration standard, The amount of time
        /// the device’s request to upload a file is valid before it
        /// expires.</param>
        /// <param name="state">The state of the file upload configuration.
        /// Possible values include: 'Pending', 'Updating', 'Deleting',
        /// 'Succeeded', 'Failed'</param>
        /// <param name="etag">ETag used to prevent conflict with multiple
        /// uploads</param>
        public FileUpload(string connectionString, string container, string account = default(string), string sasTtl = default(string), FileUploadState? state = default(FileUploadState?), string etag = default(string))
        {
            Account = account;
            ConnectionString = connectionString;
            Container = container;
            SasTtl = sasTtl;
            State = state;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the storage account name where to upload the file to
        /// </summary>
        [JsonProperty(PropertyName = "account")]
        public string Account { get; set; }

        /// <summary>
        /// Gets or sets the connection string used to configure the storage
        /// account
        /// </summary>
        [JsonProperty(PropertyName = "connectionString")]
        public string ConnectionString { get; set; }

        /// <summary>
        /// Gets or sets the name of the container inside the storage account
        /// </summary>
        [JsonProperty(PropertyName = "container")]
        public string Container { get; set; }

        /// <summary>
        /// Gets or sets ISO 8601 duration standard, The amount of time the
        /// device’s request to upload a file is valid before it expires.
        /// </summary>
        [JsonProperty(PropertyName = "sasTtl")]
        public string SasTtl { get; set; }

        /// <summary>
        /// Gets the state of the file upload configuration. Possible values
        /// include: 'Pending', 'Updating', 'Deleting', 'Succeeded', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public FileUploadState? State { get; private set; }

        /// <summary>
        /// Gets or sets eTag used to prevent conflict with multiple uploads
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}
