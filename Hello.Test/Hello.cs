using Hello;
using NUnit.Framework;

namespace Hello.Tests
{
	[TestFixture ()]
	public class SayHelloTest
	{
		[Test ()]
		public void SayHello ()
		{
			Assert.AreEqual("Hello World!", Hello.SayHello ());
		}
	}
}
