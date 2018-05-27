using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Command command = new Command();
            
        
            while(command.Name != "q")
            {
                command.Name = Console.ReadLine();
                switch (command.Name)
                {
                    case "help":
                        Menu();
                        break;
                    case "dir":
                        {
                            string dir = Environment.CurrentDirectory;
                            Console.WriteLine("Your directory is" + " " + dir);
                        }
                        break;
                    case "disks":
                        {
                            string[] disks = Environment.GetLogicalDrives();
                            Console.WriteLine(disks[0]);
                        }
                        break;
                    case "is64bitop":
                        {
                           
                            if (Environment.Is64BitOperatingSystem)
                            {
                                Console.WriteLine("YES");
                            }
                            else
                            {
                                Console.WriteLine("NO");
                            }
                          
                        }
                        break;
                    case "is64bitproc":
                        {
                            
                            if (Environment.Is64BitProcess)
                            {
                                Console.WriteLine("YES");
                            }
                            else
                            {
                                Console.WriteLine("NO");
                            }
                        }
                        break;
                    case "macname":
                        {
                            string is64proc = Environment.MachineName;
                            Console.WriteLine(is64proc);
                        }
                        break;
                    case "osdetail":
                        {
                           Console.WriteLine(Environment.OSVersion);
                        }
                        break;
                    case "osplatform":
                        {
                            Console.WriteLine(Environment.OSVersion.Platform);
                        }
                        break;
                    case "osversion":
                        {
                            Console.WriteLine(Environment.OSVersion);
                        }
                        break;
                    case "domname":
                        {
                            string domname = Environment.UserDomainName;
                            Console.WriteLine(domname);
                        }
                        break;
                    case "username":
                        {
                            string username = Environment.UserName;
                            Console.WriteLine(username);
                        }
                        break;
                    case "osdir":
                        {
                            string osdir = Environment.SystemDirectory;
                            Console.WriteLine(osdir);
                        }
                        break;
                    
                }
             
            }
        }

        static void Menu()
        {
            Console.WriteLine("dir - Enviroment.CurrentDirectory");
            Console.WriteLine("disks - Enviroment.GetLogicalDrives()");
            Console.WriteLine("is64bitop - Enviroment.64BitOperationSystem");
            Console.WriteLine("is64bitproc - Enviroment.Is64BitProcess");
            Console.WriteLine("macname  - Enviroment.MachineName");
            Console.WriteLine("osdetail  - Enviroment.OSVersion;");
            Console.WriteLine("osplatform  - Enviroment.OSVersion.Platform;");
            Console.WriteLine("osversion  - Enviroment.OSVersion.Version");
            Console.WriteLine("domname   - Enviroment.UserDomainName");
            Console.WriteLine("username   - Enviroment.UserName");
            Console.WriteLine("osdir   - Enviroment.SystemDirectory");
        }
    }
}
