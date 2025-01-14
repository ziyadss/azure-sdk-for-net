// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class AutomationRunbookTaskDetails
    {
        internal static AutomationRunbookTaskDetails DeserializeAutomationRunbookTaskDetails(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> cloudServiceName = default;
            Optional<string> subscriptionId = default;
            Optional<string> accountName = default;
            Optional<string> runbookId = default;
            Optional<string> runbookName = default;
            Optional<string> jobId = default;
            Optional<string> jobOutput = default;
            Optional<bool> isPrimarySideScript = default;
            string instanceType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cloudServiceName"))
                {
                    cloudServiceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionId"))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accountName"))
                {
                    accountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runbookId"))
                {
                    runbookId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runbookName"))
                {
                    runbookName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobId"))
                {
                    jobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobOutput"))
                {
                    jobOutput = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isPrimarySideScript"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isPrimarySideScript = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("instanceType"))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
            }
            return new AutomationRunbookTaskDetails(instanceType, name.Value, cloudServiceName.Value, subscriptionId.Value, accountName.Value, runbookId.Value, runbookName.Value, jobId.Value, jobOutput.Value, Optional.ToNullable(isPrimarySideScript));
        }
    }
}
