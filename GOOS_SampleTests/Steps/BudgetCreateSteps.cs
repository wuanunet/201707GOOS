﻿using FluentAutomation;
using GOOS_SampleTests.PageObjects;
using TechTalk.SpecFlow;

namespace GOOS_SampleTests.Steps
{
    [Binding]
    [Scope(Feature = "BudgetCreate")]
    public class BudgetCreateSteps : FluentTest
    {
        private BudgetCreatePage _budgetCreatePage;

        public BudgetCreateSteps()
        {
            this._budgetCreatePage = new BudgetCreatePage(this);
        }

        [BeforeScenario()]
        public void BeforeScenario()
        {
            SeleniumWebDriver.Bootstrap(SeleniumWebDriver.Browser.Chrome);
        }

        [Given(@"go to adding budget page")]
        public void GivenGoToAddingBudgetPage()
        {
            this._budgetCreatePage.Go();
        }

        [When(@"I add a buget (.*) for ""(.*)""")]
        public void WhenIAddABugetFor(int amount, string yearMonth)
        {

            this._budgetCreatePage
                .Amount(amount)
                .Month(yearMonth)
                .AddBudget();
        }

        [Then(@"it should display ""(.*)""")]
        public void ThenItShouldDisplay(string message)
        {
            this._budgetCreatePage.ShouldDisplay(message);
        }
    }
}
