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
namespace CustomExtensions
{
	//Extension methods must be defined in a static class 
	public static class StringExtension
	{
		// This is the extension method. 
		// The first parameter takes the "this" modifier
		// and specifies the type for which the method is defined. 
		public static void toEcho2(this String str)
		{
			Console.WriteLine ("extend Method #2");
		}
	}
}

namespace MyServe
{
	// mix-in extension method
	// 必須寫於 Namespace 最上方
	using CustomExtensions;
	using myExtension;

	// MonkeyPatch & Prototype Extends
	public static class method
	{
		public static void toEcho(this String str){
			Console.WriteLine ("String.toEcho() extension method");
		}
	}
		
	// Main
	class MainClass
	{
		public static void Main (string[] args)
		{
			var uri = "http://localhost:9999";
			Console.WriteLine (uri);
			String test = "123123";
			test.toEcho ();			// extend from Program.cs
			test.toEcho2 ();		// extend from Program.cs
			test.toEcho3 ();		// extend from myExtension.cs

			Console.WriteLine (test);
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
