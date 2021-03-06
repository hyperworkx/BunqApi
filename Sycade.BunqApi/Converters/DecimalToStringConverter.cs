﻿using Newtonsoft.Json;
using System;
using System.Globalization;

namespace Sycade.BunqApi.Converters
{
    class DecimalToStringConverter : JsonConverter
    {
        private static readonly CultureInfo UnitedStatesCultureInfo = new CultureInfo("en-US");

        public override bool CanConvert(Type objectType) => objectType == typeof(decimal);

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) => decimal.Parse((string)reader.Value, UnitedStatesCultureInfo);

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(Math.Round((decimal)value, 2, MidpointRounding.AwayFromZero).ToString(UnitedStatesCultureInfo));
        }
    }
}
