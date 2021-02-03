using System;
using System.Reflection;

namespace Codefire.Extensions {
    public static class TypeExtensions {
        public static PropertyInfo GetPropertyAccessor(this Type type, string name)
        {
            return type.GetProperty(name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.IgnoreCase);
        }

        public static bool IsNullable(this Type type)
        {
            return type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>);
        }
    }
}