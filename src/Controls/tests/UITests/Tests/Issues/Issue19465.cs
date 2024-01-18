﻿using NUnit.Framework;
using UITest.Appium;
using UITest.Core;

namespace Microsoft.Maui.AppiumTests.Issues
{
	public class Issue19465 : _IssuesUITest
	{
		public Issue19465(TestDevice device)
			: base(device)
		{ }

		public override string Issue => "Double tap gesture NullReferenceException when navigating";

		[Test]
		public void Issue19465Test()
		{
			// 1. Navigate to a second page.
			App.WaitForElement("FirstButton");
			App.Click("FirstButton");

			// 2. Double tap (gesture) a Label to navigate again.
			// Without exceptions, the test already passed.
			App.WaitForElement("SecondLabel");
			App.DoubleClick("SecondLabel");

			// 3. Navigate back.
			App.WaitForElement("ThirdButton");
			App.DoubleClick("ThirdButton");
			App.Back();
		}
	}
}