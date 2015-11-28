using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleLinqIntro
{
    public class Program
    {
        public static void Main()
        {
            IEnumerable<Process> processList = from p in Process.GetProcesses()
                                               where String.Equals(p.ProcessName, "svchost")
                                               orderby p.WorkingSet64 descending
                                               select p;
            foreach (Process p in processList)
            {
                Console.WriteLine("{0,10} ({ 1,4}) : { 2,15:N0}", p.ProcessName, p.Id, p.WorkingSet64);
            }
        }
    }
}
