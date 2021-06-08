using System;
using System.Text;

namespace ReflectionWithCustomAttribute
{
    [SowftwareEngenear("Yusupov Ozodbek", 27, "C#")]
    public class Trade24Project : BaseProject, IProject
    {
        public StringBuilder ClientInfo { get; set; }
        public string ServerData { get; set; }
        public Version VersionInfo { get; set; }

        public override string Name => "Trade24";

        public void Run()
        {
            Console.WriteLine($"{Name} started...");
        }
    }
}
