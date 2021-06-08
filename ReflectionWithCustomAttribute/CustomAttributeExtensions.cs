using System;
using System.Reflection;

namespace ReflectionWithCustomAttribute
{
    public static class CustomAttributeExtensions
    {
        public static bool IsHasCustomAttribute<T>(this MemberInfo element) where T : Attribute
        {
            var attr = Attribute.GetCustomAttribute(element, typeof(T));
            return attr != null;
        }
    }
}
