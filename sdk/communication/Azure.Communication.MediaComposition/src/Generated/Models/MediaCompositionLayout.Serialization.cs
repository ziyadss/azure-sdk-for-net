// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Communication.MediaComposition;
using Azure.Core;

namespace Azure.Communication.MediaComposition.Models
{
    public partial class MediaCompositionLayout : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind.ToString());
            if (Optional.IsDefined(Resolution))
            {
                writer.WritePropertyName("resolution");
                writer.WriteObjectValue(Resolution);
            }
            if (Optional.IsDefined(PlaceholderImageUri))
            {
                writer.WritePropertyName("placeholderImageUri");
                writer.WriteStringValue(PlaceholderImageUri);
            }
            writer.WriteEndObject();
        }

        internal static MediaCompositionLayout DeserializeMediaCompositionLayout(JsonElement element)
        {
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "autoGrid": return AutoGridLayout.DeserializeAutoGridLayout(element);
                    case "custom": return CustomLayout.DeserializeCustomLayout(element);
                    case "grid": return GridLayout.DeserializeGridLayout(element);
                    case "presentation": return PresentationLayout.DeserializePresentationLayout(element);
                    case "presenter": return PresenterLayout.DeserializePresenterLayout(element);
                }
            }
            LayoutType kind = default;
            Optional<LayoutResolution> resolution = default;
            Optional<string> placeholderImageUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = new LayoutType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resolution"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    resolution = LayoutResolution.DeserializeLayoutResolution(property.Value);
                    continue;
                }
                if (property.NameEquals("placeholderImageUri"))
                {
                    placeholderImageUri = property.Value.GetString();
                    continue;
                }
            }
            return new MediaCompositionLayout(kind, resolution.Value, placeholderImageUri.Value);
        }
    }
}
