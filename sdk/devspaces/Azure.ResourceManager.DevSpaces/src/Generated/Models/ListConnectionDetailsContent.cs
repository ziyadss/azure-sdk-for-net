// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DevSpaces.Models
{
    /// <summary> Parameters for listing connection details of an Azure Dev Spaces Controller. </summary>
    public partial class ListConnectionDetailsContent
    {
        /// <summary> Initializes a new instance of ListConnectionDetailsContent. </summary>
        /// <param name="targetContainerHostResourceId"> Resource ID of the target container host mapped to the Azure Dev Spaces Controller. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetContainerHostResourceId"/> is null. </exception>
        public ListConnectionDetailsContent(string targetContainerHostResourceId)
        {
            if (targetContainerHostResourceId == null)
            {
                throw new ArgumentNullException(nameof(targetContainerHostResourceId));
            }

            TargetContainerHostResourceId = targetContainerHostResourceId;
        }

        /// <summary> Resource ID of the target container host mapped to the Azure Dev Spaces Controller. </summary>
        public string TargetContainerHostResourceId { get; }
    }
}
