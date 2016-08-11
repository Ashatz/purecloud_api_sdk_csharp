using System;
using System.Linq;
using Newtonsoft.Json;

namespace ININ.PureCloudApi.Client
{
    class UpgradeSdkEnumConverter : JsonConverter
    {
        // Inspired by http://stackoverflow.com/questions/22752075/how-can-i-ignore-unknown-enum-values-during-json-deserialization

        public override bool CanConvert(Type objectType)
        {
            var type = IsNullableType(objectType) ? Nullable.GetUnderlyingType(objectType) : objectType;
            return type.IsEnum;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            var isNullable = IsNullableType(objectType);
            var enumType = isNullable ? Nullable.GetUnderlyingType(objectType) : objectType;

            var names = Enum.GetNames(enumType);

            switch (reader.TokenType)
            {
                case JsonToken.String:
                    var enumText = reader.Value.ToString();

                    if (!string.IsNullOrEmpty(enumText))
                    {
                        var match = names
                            .FirstOrDefault(n => string.Equals(n, enumText, StringComparison.OrdinalIgnoreCase));

                        if (match != null)
                        {
                            return Enum.Parse(enumType, match);
                        }
                    }
                    break;
                case JsonToken.Integer:
                    var enumVal = Convert.ToInt32(reader.Value);
                    var values = (int[]) Enum.GetValues(enumType);
                    if (values.Contains(enumVal))
                    {
                        return Enum.Parse(enumType, enumVal.ToString());
                    }
                    break;
            }

            // See if it has a member named "OUTDATED_SDK_VERSION"
            var outdatedSdkVersionMemberName = names
                .FirstOrDefault(n => string.Equals(n, "OUTDATED_SDK_VERSION", StringComparison.OrdinalIgnoreCase));

            // Return parsed "OUTDATED_SDK_VERSION" member
            return outdatedSdkVersionMemberName != default(string)
                ? Enum.Parse(enumType, outdatedSdkVersionMemberName)
                : Activator.CreateInstance(enumType);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString());
        }

        private bool IsNullableType(Type t)
        {
            return (t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>));
        }
    }
}