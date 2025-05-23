// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Responses
{
    internal partial class InternalResponsesInputFileContentPart : ResponseContentPart
    {
        public InternalResponsesInputFileContentPart() : base(InternalResponsesContentType.InputFile)
        {
        }

        internal InternalResponsesInputFileContentPart(InternalResponsesContentType internalType, IDictionary<string, BinaryData> additionalBinaryDataProperties, string fileId, string filename, BinaryData fileBytes) : base(internalType, additionalBinaryDataProperties)
        {
            FileId = fileId;
            Filename = filename;
            FileBytes = fileBytes;
        }

        public string FileId { get; set; }

        public string Filename { get; set; }
    }
}
