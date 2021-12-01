// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;

namespace Azure.Storage.Files.Shares
{
    internal partial class FileRenameHeaders
    {
        private readonly Response _response;
        public FileRenameHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> Returns the date and time the share was last modified. Any operation that modifies the directory or its properties updates the last modified time. Operations on files do not affect the last modified time of the directory. </summary>
        public DateTimeOffset? LastModified => _response.Headers.TryGetValue("Last-Modified", out DateTimeOffset? value) ? value : null;
        /// <summary> Indicates the version of the File service used to execute the request. </summary>
        public string Version => _response.Headers.TryGetValue("x-ms-version", out string value) ? value : null;
        /// <summary> The value of this header is set to true if the contents of the request are successfully encrypted using the specified algorithm, and false otherwise. </summary>
        public bool? IsServerEncrypted => _response.Headers.TryGetValue("x-ms-request-server-encrypted", out bool? value) ? value : null;
        /// <summary> Key of the permission set for the file. </summary>
        public string FilePermissionKey => _response.Headers.TryGetValue("x-ms-file-permission-key", out string value) ? value : null;
        /// <summary> Attributes set for the file. </summary>
        public string FileAttributes => _response.Headers.TryGetValue("x-ms-file-attributes", out string value) ? value : null;
        /// <summary> Creation time for the file. </summary>
        public DateTimeOffset? FileCreationTime => _response.Headers.TryGetValue("x-ms-file-creation-time", out DateTimeOffset? value) ? value : null;
        /// <summary> Last write time for the file. </summary>
        public DateTimeOffset? FileLastWriteTime => _response.Headers.TryGetValue("x-ms-file-last-write-time", out DateTimeOffset? value) ? value : null;
        /// <summary> Change time for the file. </summary>
        public DateTimeOffset? FileChangeTime => _response.Headers.TryGetValue("x-ms-file-change-time", out DateTimeOffset? value) ? value : null;
        /// <summary> The fileId of the file. </summary>
        public string FileId => _response.Headers.TryGetValue("x-ms-file-id", out string value) ? value : null;
    }
}
