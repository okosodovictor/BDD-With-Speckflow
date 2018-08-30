using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace BDDSample.specs
{
    [Binding]
    public class CustomerTransferSFundSteps
    {
        FundTransferPage _ftPage = new FundTransferPage(Environment.Driver);

        [Given(@"the user is on Fund Transfer Page")]
        public void GivenTheUserIsOnFundTransferPage()
        {
            Environment.Driver.Navigate().GoToUrl("http://localhost:64895/Default.aspx");
        }
        
        [Given(@"he enters ""(.*)"" as amount")]
        public void GivenHeEntersAsAmount(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"he Submits request for Fund Transfer")]
        public void GivenHeSubmitsRequestForFundTransfer()
        {
            _ftPage.transferButton.Click();
        }  
        
        [When(@"he enters ""(.*)"" as payee name")]
        public void WhenHeEntersAsPayeeName(string payeeName)
        {
            _ftPage.payeeNameField.SendKeys(payeeName);
        }
        
        [When(@"he enters ""(.*)"" as amount")]
        public void WhenHeEntersAsAmount(string amount)
        {
            _ftPage.amountField.SendKeys(amount);
        }
        
        [When(@"he Submits request for Fund Transfer")]
        public void WhenHeSubmitsRequestForFundTransfer()
        {
            _ftPage.transferButton.Click();
        }
       
        [Then(@"ensure the fund transfer is complete with ""(.*)"" message")]
        public void ThenEnsureTheFundTransferIsCompleteWithMessage(string message)
        {
            Assert.AreEqual(message, _ftPage.messageLabel.Text);
        }
        
        [Then(@"ensure a transaction failure message ""(.*)"" is displayed")]
        public void ThenEnsureATransactionFailureMessageIsDisplayed(string message)
        {
            Assert.AreEqual(message, _ftPage.messageLabel.Text);
        }
    }
}
