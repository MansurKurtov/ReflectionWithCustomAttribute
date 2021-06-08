using System;
using System.Linq;
using System.Reflection;

namespace ReflectionWithCustomAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseProjectType = typeof(BaseProject);

            //getting all types which has SowftwareEngenear custom attribute:
            var projectTypes = Assembly.GetExecutingAssembly().GetTypes().
                Where(w => baseProjectType.IsAssignableFrom(w) && 
                w.IsHasCustomAttribute<SowftwareEngenear>()).ToList();

            //Starting all projects:
            projectTypes.ForEach(f =>
            {
                var project = Activator.CreateInstance(f) as IProject;
                project.Run();
            });

            Console.ReadKey();
        }
    }
}
