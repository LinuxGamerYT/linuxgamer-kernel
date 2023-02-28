using System;

namespace kernel
{
	class compile
	{
		static void Main(string []args)
		{
			while (true)
			{
				Console.WriteLine("██╗░░░░░██╗███╗░░██╗██╗░░░██╗██╗░░██╗░██████╗░░█████╗░███╗░░░███╗███████╗██████╗░");
				Console.WriteLine("██║░░░░░██║████╗░██║██║░░░██║╚██╗██╔╝██╔════╝░██╔══██╗████╗░████║██╔════╝██╔══██╗");
				Console.WriteLine("██║░░░░░██║██╔██╗██║██║░░░██║░╚███╔╝░██║░░██╗░███████║██╔████╔██║█████╗░░██████╔╝");
				Console.WriteLine("██║░░░░░██║██║╚████║██║░░░██║░██╔██╗░██║░░╚██╗██╔══██║██║╚██╔╝██║██╔══╝░░██╔══██╗");
				Console.WriteLine("███████╗██║██║░╚███║╚██████╔╝██╔╝╚██╗╚██████╔╝██║░░██║██║░╚═╝░██║███████╗██║░░██║");
				Console.WriteLine("╚══════╝╚═╝╚═╝░░╚══╝░╚═════╝░╚═╝░░╚═╝░╚═════╝░╚═╝░░╚═╝╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚═╝");				
				Console.WriteLine("root@kernel$ ");
				var command = Console.ReadLine();
				if (command == "help")
				{
					Console.WriteLine("ver to display kernel and os info");
					Console.WriteLine("control+C to exit");
				}
				if (command == "ver")
				{
					Console.WriteLine("OS: LinuxGamerOS ");
					Console.WriteLine("OS version: 1.0");
					Console.WriteLine("Kernel: LinuxGamerKernel");
					Console.WriteLine("Kernel version: 1.0");
				}                                  
			}
		}
	}
}
