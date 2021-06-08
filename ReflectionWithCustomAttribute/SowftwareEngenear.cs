using System;

namespace ReflectionWithCustomAttribute
{
    public class SowftwareEngenear : Attribute
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Language { get; set; }
        public SowftwareEngenear(string name, int age, string language)
        {
            Name = name;
            Age = age;
            Language = language;
        }
    }
}
