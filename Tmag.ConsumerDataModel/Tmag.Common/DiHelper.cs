using Microsoft.Extensions.DependencyModel;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Tmag.Common
{
    public class DiHelper
    {

        public Assembly[] GetAssemblies(List<string> libraryNames)
        {
            var assemblies = new List<Assembly>();
            var dependencies = DependencyContext.Default.RuntimeLibraries;
            foreach (var library in dependencies)
            {
                if (IsCandidateCompilationLibrary(library, libraryNames))
                {
                    var assembly = Assembly.Load(new AssemblyName(library.Name));
                    assemblies.Add(assembly);
                }
            }
            return assemblies.ToArray();
        }

        private static bool IsCandidateCompilationLibrary(RuntimeLibrary compilationLibrary, List<string> libraryNames)
        {
            return libraryNames.Contains(compilationLibrary.Name)
                || libraryNames.Any(x => compilationLibrary.Name.StartsWith(x))
                   || compilationLibrary.Dependencies.Any(d => libraryNames.Any(x => d.Name.StartsWith(x)));
        }
    }
}
