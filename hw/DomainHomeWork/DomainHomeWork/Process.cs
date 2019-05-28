using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainHomeWork
{
    public class Process
    {
        public void Domain(string name)
        {
            var currentDomain = AppDomain.CurrentDomain;

            var exampleDomain = AppDomain.CreateDomain(name);

            string assemblyForExampleDomain = currentDomain.BaseDirectory + name + ".exe";
            exampleDomain.ExecuteAssembly(assemblyForExampleDomain);

            AppDomain.Unload(exampleDomain);
        }
    }
}
