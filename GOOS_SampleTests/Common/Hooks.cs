using FluentAutomation;
using TechTalk.SpecFlow;

namespace GOOS_SampleTests.Common
{
    [Binding]
    public sealed class Hooks
    {
        [BeforeFeature()]
        [Scope(Tag = "web")]
        public static void SetBrowser()
        {
            SeleniumWebDriver.Bootstrap(SeleniumWebDriver.Browser.Chrome);
        }
    }
}