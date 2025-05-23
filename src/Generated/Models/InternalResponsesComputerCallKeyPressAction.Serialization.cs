// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Responses
{
    internal partial class InternalResponsesComputerCallKeyPressAction : IJsonModel<InternalResponsesComputerCallKeyPressAction>
    {
        internal InternalResponsesComputerCallKeyPressAction()
        {
        }

        void IJsonModel<InternalResponsesComputerCallKeyPressAction>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponsesComputerCallKeyPressAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalResponsesComputerCallKeyPressAction)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            if (_additionalBinaryDataProperties?.ContainsKey("keys") != true)
            {
                writer.WritePropertyName("keys"u8);
                writer.WriteStartArray();
                foreach (string item in Keys)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
        }

        InternalResponsesComputerCallKeyPressAction IJsonModel<InternalResponsesComputerCallKeyPressAction>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (InternalResponsesComputerCallKeyPressAction)JsonModelCreateCore(ref reader, options);

        protected override ComputerCallAction JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponsesComputerCallKeyPressAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalResponsesComputerCallKeyPressAction)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalResponsesComputerCallKeyPressAction(document.RootElement, options);
        }

        internal static InternalResponsesComputerCallKeyPressAction DeserializeInternalResponsesComputerCallKeyPressAction(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ComputerCallActionKind kind = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            IList<string> keys = default;
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("type"u8))
                {
                    kind = prop.Value.GetString().ToComputerCallActionKind();
                    continue;
                }
                if (prop.NameEquals("keys"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    keys = array;
                    continue;
                }
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalResponsesComputerCallKeyPressAction(kind, additionalBinaryDataProperties, keys);
        }

        BinaryData IPersistableModel<InternalResponsesComputerCallKeyPressAction>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponsesComputerCallKeyPressAction>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalResponsesComputerCallKeyPressAction)} does not support writing '{options.Format}' format.");
            }
        }

        InternalResponsesComputerCallKeyPressAction IPersistableModel<InternalResponsesComputerCallKeyPressAction>.Create(BinaryData data, ModelReaderWriterOptions options) => (InternalResponsesComputerCallKeyPressAction)PersistableModelCreateCore(data, options);

        protected override ComputerCallAction PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalResponsesComputerCallKeyPressAction>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalResponsesComputerCallKeyPressAction(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalResponsesComputerCallKeyPressAction)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalResponsesComputerCallKeyPressAction>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(InternalResponsesComputerCallKeyPressAction internalResponsesComputerCallKeyPressAction)
        {
            if (internalResponsesComputerCallKeyPressAction == null)
            {
                return null;
            }
            return BinaryContent.Create(internalResponsesComputerCallKeyPressAction, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator InternalResponsesComputerCallKeyPressAction(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeInternalResponsesComputerCallKeyPressAction(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
