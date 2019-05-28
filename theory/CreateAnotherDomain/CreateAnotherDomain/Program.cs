using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAnotherDomain
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentDomain = AppDomain.CurrentDomain;
            ShowDomainInfo(currentDomain);

            var calcDomain = AppDomain.CreateDomain("Calculator");
            ShowDomainInfo(calcDomain);

            string assemblyForCalcuDomain = currentDomain.BaseDirectory + "CalcSum.exe";
            calcDomain.ExecuteAssembly(assemblyForCalcuDomain, new string[] { "10", "15" });
            //ShowDomainInfo(calcDomain);

            AppDomain.Unload(calcDomain);
            Console.ReadLine();
        }

        private static void ShowDomainInfo(AppDomain currentDomain)
        {
            var sortedAssemblies = currentDomain.GetAssemblies()
                .OrderBy(assembly => assembly.GetName().Name);

            Console.WriteLine($"***{currentDomain.FriendlyName}***");

            foreach (var assembly in sortedAssemblies)
            {
                Console.WriteLine($"{assembly.GetName().Name} - {assembly.Location}");
            }

            Console.ReadLine();
        }
    }
}
