using System;

namespace myExtension
{
//	public class myExtension
//	{
//		public myExtension ()
//		{
//		}
//	}
	//Extension methods must be defined in a static class 
	public static class StringExtension
	{
		// This is the extension method. 
		// The first parameter takes the "this" modifier
		// and specifies the type for which the method is defined. 
		public static void toEcho3(this String str)
		{
			Console.WriteLine ("extend Method #3");
		}
	}
}

