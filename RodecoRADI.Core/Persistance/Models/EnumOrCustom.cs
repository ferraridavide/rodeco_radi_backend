using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace RodecoRADI.Core.Persistance.Models
{
    [Owned]
    public class EnumOrCustom<T> where T : struct, Enum?
    {
        public Nullable<T> Value { get; set; }
        public string? Custom { get; set; }

        public EnumOrCustom() { }
        public EnumOrCustom(T value) { Value = value; }
        public EnumOrCustom(string custom) { Custom = custom; }

        public static implicit operator EnumOrCustom<T>(T t) => new EnumOrCustom<T>(t);
        public static implicit operator EnumOrCustom<T>(string t) => new EnumOrCustom<T>(t);
    }
}
