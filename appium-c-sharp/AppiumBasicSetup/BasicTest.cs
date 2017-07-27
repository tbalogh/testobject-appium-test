using NUnit.Framework;
using System;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium;

namespace AppiumBasicSetup
{
	[TestFixture]
	public class BasicTest
	{
		AndroidDriver<AppiumWebElement> driver;

		[SetUp()]
		public void SetUp()
		{
			Console.Write("Setting up the test");
			DesiredCapabilities capabilities = new DesiredCapabilities();
			capabilities.SetCapability("testobject_api_key", "my_api_key");
			capabilities.SetCapability("testobject_device", "Samsung_Galaxy_S6_real");
			Uri server = new Uri("url_given_in_testobject_project");

			driver = new AndroidDriver<AppiumWebElement>(server, capabilities);
		}

		[Test()]
		public void FirstTest()
		{
			driver.GetScreenshot();
		}

		[TearDown()]
		public void TearDown()
		{
			driver.Quit();
			Console.Write("Tearing down the test");
		}
	}
}
