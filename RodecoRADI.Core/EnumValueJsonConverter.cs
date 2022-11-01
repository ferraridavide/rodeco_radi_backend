using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using System.Reflection;

namespace RodecoRADI.Core
{
    //public class EnumValueJsonConverter<T> : JsonConverter<T?> where T : Enum
    //{
    //    public override T? Read(
    //        ref Utf8JsonReader reader,
    //        Type typeToConvert,
    //        JsonSerializerOptions options)
    //    {
    //        var input = reader.GetString();
    //        if (string.IsNullOrEmpty(input))
    //        {
    //            return default(T);
    //        }
    //        else
    //        {
    //            return (T)Enum.Parse(typeof(T), input);
    //        }
    //    }

    //    public override void Write(
    //        Utf8JsonWriter writer,
    //        T? dateTimeValue,
    //        JsonSerializerOptions options) =>
    //            writer.WriteStringValue(dateTimeValue.ToString());

    //}

    public class NullableConverterFactory : JsonConverterFactory
    {
        static readonly byte[] Empty = Array.Empty<byte>();

        public override bool CanConvert(Type typeToConvert) => Nullable.GetUnderlyingType(typeToConvert) != null;

        public override JsonConverter CreateConverter(Type type, JsonSerializerOptions options) =>
            (JsonConverter)Activator.CreateInstance(
                typeof(NullableConverter<>).MakeGenericType(
                    new Type[] { Nullable.GetUnderlyingType(type) }),
                BindingFlags.Instance | BindingFlags.Public,
                binder: null,
                args: new object[] { options },
                culture: null);

        class NullableConverter<T> : JsonConverter<T?> where T : struct
        {
            // DO NOT CACHE the return of (JsonConverter<T>)options.GetConverter(typeof(T)) as DoubleConverter.Read() and DoubleConverter.Write()
            // DO NOT WORK for nondefault values of JsonSerializerOptions.NumberHandling which was introduced in .NET 5
            public NullableConverter(JsonSerializerOptions options) { }

            public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                if (reader.TokenType == JsonTokenType.String)
                {
                    if (reader.ValueTextEquals(Empty))
                        return null;
                }
                return JsonSerializer.Deserialize<T>(ref reader, options);
            }

            public override void Write(Utf8JsonWriter writer, T? value, JsonSerializerOptions options) =>
                JsonSerializer.Serialize(writer, value.Value, options);
        }
    }
}
