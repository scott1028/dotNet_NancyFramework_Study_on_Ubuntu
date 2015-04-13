using System;
using Nancy;
using Nancy.TinyIoc;

/*
 * Override BootStrapper
 * 似乎 C# 的 Override 方式與 Java 非常類似！
*/

namespace myWebServe
{
	public class Bootstrapper:DefaultNancyBootstrapper
	{
		protected override void ApplicationStartup(TinyIoCContainer container, Nancy.Bootstrapper.IPipelines pipelines)
		{
			base.ApplicationStartup (container, pipelines);
			StaticConfiguration.DisableErrorTraces = false;
		}
	}
}

