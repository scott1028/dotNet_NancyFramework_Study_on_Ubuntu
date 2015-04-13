using System;
using Nancy.Hosting.Self;
using System.Threading;
using System.Linq;

/*
 * ref: http://nancyfx.org/
 * ref: https://github.com/NancyFx/Nancy/wiki/Hosting-Nancy-with-Nginx-on-Ubuntu#create-nancy-website
 * ref: https://github.com/NancyFx/Nancy/wiki/Defining-routes#going-crazy-with-routes
 * ref: https://github.com/NancyFx/Nancy/wiki/Defining-routes#condition
 * ref: https://github.com/NancyFx/Nancy/wiki/Defining-routes#route-segment-constraints
 * ref: http://stackoverflow.com/questions/15350552/how-to-get-real-error-messages-in-nancy-on-mono
*/

namespace MyServe
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var uri = "http://localhost:9999";
			Console.WriteLine (uri);
			var host = new NancyHost (new Uri(uri));
			Console.WriteLine (host);
			host.Start ();

			if (args.Any(s => s.Equals("-d", StringComparison.CurrentCultureIgnoreCase)))
			{
				Thread.Sleep(Timeout.Infinite);
			}
			else
			{
				Console.ReadKey();
			}

			host.Stop();  // stop hosting

			Console.WriteLine ("Hello World!@");
		}
	}
}