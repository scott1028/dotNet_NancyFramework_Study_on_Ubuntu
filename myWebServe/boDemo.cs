using System;
using Nancy;

namespace businessLogic
{
	public class boDemo:NancyModule
	{
		public boDemo ()
		{
			Get ["/"] = _ => "Hello World";

			Get ["/test"] = _ => "Hello World#2";

			Get ["/product/{id}"] = myParams =>
			{
				var tmp = myParams.id;
				Console.WriteLine((String)tmp);
				Console.WriteLine(tmp is String);
				return "Hello World#3:" + tmp;
			};
		}
	}
}

