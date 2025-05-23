// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Assistants
{
    public partial class FunctionToolDefinition : IJsonModel<FunctionToolDefinition>
    {
        internal FunctionToolDefinition()
        {
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<FunctionToolDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FunctionToolDefinition)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            if (_additionalBinaryDataProperties?.ContainsKey("function") != true)
            {
                writer.WritePropertyName("function"u8);
                writer.WriteObjectValue(_internalFunction, options);
            }
        }

        FunctionToolDefinition IJsonModel<FunctionToolDefinition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (FunctionToolDefinition)JsonModelCreateCore(ref reader, options);

        protected override ToolDefinition JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<FunctionToolDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FunctionToolDefinition)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFunctionToolDefinition(document.RootElement, options);
        }

        internal static FunctionToolDefinition DeserializeFunctionToolDefinition(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string @type = "function";
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            InternalFunctionDefinition internalFunction = default;
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("type"u8))
                {
                    @type = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("function"u8))
                {
                    internalFunction = InternalFunctionDefinition.DeserializeInternalFunctionDefinition(prop.Value, options);
                    continue;
                }
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new FunctionToolDefinition(@type, additionalBinaryDataProperties, internalFunction);
        }

        BinaryData IPersistableModel<FunctionToolDefinition>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<FunctionToolDefinition>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FunctionToolDefinition)} does not support writing '{options.Format}' format.");
            }
        }

        FunctionToolDefinition IPersistableModel<FunctionToolDefinition>.Create(BinaryData data, ModelReaderWriterOptions options) => (FunctionToolDefinition)PersistableModelCreateCore(data, options);

        protected override ToolDefinition PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<FunctionToolDefinition>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeFunctionToolDefinition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FunctionToolDefinition)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FunctionToolDefinition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(FunctionToolDefinition functionToolDefinition)
        {
            if (functionToolDefinition == null)
            {
                return null;
            }
            return BinaryContent.Create(functionToolDefinition, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator FunctionToolDefinition(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeFunctionToolDefinition(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
