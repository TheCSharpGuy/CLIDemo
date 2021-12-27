using System;

namespace CLIDemo
{
    class Program
    {
        static void osinfo()
        {
            Console.WriteLine("Operating System Detaiils");
            OperatingSystem os = Environment.OSVersion;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"Version:{os.Version}. Platoform:{os.Platform}.Service Pack:{os.ServicePack}");
            Console.WriteLine($"Version String:{os.VersionString}");
            Console.WriteLine();
            Console.ResetColor();
            // Get Version details
            Version ver = os.Version;
            Console.WriteLine($"Major version:{ver.Major}. Major Revision:{ver.MajorRevision}.\nMinor version:{ver.Minor}. Minor Revision:{ver.MinorRevision}.\nBuild:{ver.Build}");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {

            if (args.Length < 1)
                Console.WriteLine("Invalid parameter/option.\ntype clidemo os");
            else if (args.Length == 1)
            {
                if (args[0].ToLower() == "os")
                {
                    osinfo();
                }
                else
                    Console.WriteLine("Invalid parameter/option.\ntype clidemo os");

            }
        }
    }
}
