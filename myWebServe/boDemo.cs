using Nancy;

namespace businessLogic
{
	public class boDemo:NancyModule
	{
		public boDemo ()
		{
			Get ["/"] = _ => "Hello World";

			Get ["/test"] = _ => "Hello World#2";
		}
	}
}

