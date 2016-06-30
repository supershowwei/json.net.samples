using System;
using System.Collections.Generic;
using System.Linq;
using JsonNetSamples.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JsonNetSamples
{
    internal class FieldConverter : JsonConverter
    {
        public override bool CanWrite
        {
            get
            {
                return false;
            }
        }

        public override bool CanConvert(Type objectType)
        {
            return
                objectType.Equals(typeof(List<Field>))
                || objectType.Equals(typeof(Field));
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType.Equals(JsonToken.StartArray))
            {
                return
                    JArray.Load(reader)
                        .Cast<JObject>()
                        .Select(o => GenerateFieldObject(o, serializer))
                        .ToList();
            }

            if (reader.TokenType.Equals(JsonToken.StartObject))
            {
                return GenerateFieldObject(JObject.Load(reader), serializer);
            }

            return null;
        }

        private Field GenerateFieldObject(JObject jsonObject, JsonSerializer serializer)
        {
            switch ((FieldType)(int)jsonObject["Type"])
            {
                case FieldType.Radio: return jsonObject.ToObject<RadioField>(serializer);
                case FieldType.CheckBox: return jsonObject.ToObject<CheckField>(serializer);
                case FieldType.DropDownList: return jsonObject.ToObject<DropDownField>(serializer);
                case FieldType.ShortText: return jsonObject.ToObject<ShortTextField>(serializer);
                case FieldType.Paragraph: return jsonObject.ToObject<ParagraphField>(serializer);
                case FieldType.DateTime: return jsonObject.ToObject<DateTimeField>(serializer);
                case FieldType.Attachment: return jsonObject.ToObject<AttachmentField>(serializer);
                default: return null;
            }
        }
    }
}