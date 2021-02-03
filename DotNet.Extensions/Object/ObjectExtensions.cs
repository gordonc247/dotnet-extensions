using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Reflection;

namespace DotNet.Extensions {
    public static class ObjectExtensions {
        public static object GetPropertyValue(this object obj, string name)
        {
            var accessor = obj.GetType().GetPropertyAccessor(name);

            return accessor?.GetValue(obj);
        }

        public static bool SetPropertyValue(this object obj, string name, object value)
        {
            var accessor = obj.GetType().GetPropertyAccessor(name);
            if (accessor == null) return false;

            var propertyType = accessor.PropertyType;
            accessor.SetValue(obj, ChangeType(value, propertyType));

            return true;
        }

        public static object ChangeType(object value, Type type)
        {
            if (value == null) return null;

            if (type.IsNullable())
            {
                type = Nullable.GetUnderlyingType(type);
            }

            if (type == value.GetType()) return value;
            if (value is string && type == typeof(Guid)) return new Guid(value as string);
            if (!(value is IConvertible)) return value;

            return Convert.ChangeType(value, type);
        }

        public static dynamic ToDynamic<T>(this T obj)
        {
            IDictionary<string, object> expando = new ExpandoObject();

            foreach (var propertyInfo in typeof(T).GetProperties())
            {
                var currentValue = propertyInfo.GetValue(obj);
                expando.Add(propertyInfo.Name, currentValue);
            }

            return expando as ExpandoObject;
        }
    }
}