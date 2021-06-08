using System;

namespace ReflectionWithCustomAttribute
{
    [SowftwareEngenear("Safarov Alisher", 26, "C++")]
    public class TerminalProject : BaseProject, IProject
    {
        public int TerminalsCount { get; set; }
        public string KPKeys { get; set; }
        public string MasterKeyVersion { get; set; }

        public override string Name => "Terminal";
        public void Run()
        {
            Console.WriteLine($"{Name} started...");
        }
    }
}
