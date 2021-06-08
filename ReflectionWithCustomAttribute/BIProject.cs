using System;

namespace ReflectionWithCustomAttribute
{
    [SowftwareEngenear("Mansur Kurtov", 30, "C#")]
    public class BIProject : BaseProject, IProject
    {
        public string Description { get; set; }
        public string Units { get; set; }
        public override string Name => "BI";

        public void Run()
        {
            Console.WriteLine($"{Name} started...");
        }
    }
}
