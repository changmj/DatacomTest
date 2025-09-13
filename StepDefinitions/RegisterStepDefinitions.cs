using System;
using Reqnroll;
using Reqnroll.Assist.Dynamic;
using DatacomTest.Drivers;
using DatacomTest.Pages;
using DatacomTest.Models;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DatacomTest.StepDefinitions
{
    [Binding]
    public class RegisterStepDefinitions
    {
        private readonly Driver _driver;
        private readonly RegisterPage _registerPage;

        public RegisterStepDefinitions(Driver driver) {
            _driver = driver;
            _registerPage = new RegisterPage(_driver.Page);
        }

        [Given("open the register page")]
        public void GivenOpenTheRegisterPage()
        {
            _driver.Page.GotoAsync("https://qa-practice.netlify.app/bugs-form");
        }

        [Then("The Labels, styles, placehoders and help text of each feild should looks like as below:")]
        public void ThenTheLabelsStylesPlacehodersAndHelpTextOfEachFeildShouldLooksLikeAsBelow(DataTable dataTable)
        {
            throw new PendingStepException();
        }

        [Then("The check box for the agreement of terms and conditions should be able to editable")]
        public void ThenTheCheckBoxForTheAgreementOfTermsAndConditionsShouldBeAbleToEditable()
        {
            throw new PendingStepException();
        }

        [Then("there should a link on the field to open the terms and conditions")]
        public void ThenThereShouldALinkOnTheFieldToOpenTheTermsAndConditions()
        {
            throw new PendingStepException();
        }

        [Then("Password should be displayed as hidden text")]
        public void ThenPasswordShouldBeDisplayedAsHiddenText()
        {
            throw new PendingStepException();
        }

        [Then("Should have confirm Password field")]
        public void ThenShouldHaveConfirmPasswordField()
        {
            throw new PendingStepException();
        }

        [Then("each drop down item should have unique value and text")]
        public void ThenEachDropDownItemShouldHaveUniqueValueAndText()
        {
            throw new PendingStepException();
        }

        [Given("input valid data to all of the fields \\(Note: except term check box. It's blocked by a defect)")]
        public void GivenInputValidDataToAllOfTheFieldsNoteExceptTermCheckBox_ItsBlockedByADefect()
        {
            throw new PendingStepException();
        }

        [When("I change the value in following field to empty")]
        public void WhenIChangeTheValueInFollowingFieldToEmpty()
        {
            throw new PendingStepException();
        }

        [When("click the register button")]
        public void WhenClickTheRegisterButton()
        {
            throw new PendingStepException();
        }

        [Then("[outcome]")]
        public void ThenOutcome()
        {
            throw new PendingStepException();
        }

        [Given("[context]")]
        public void GivenContext()
        {
            throw new PendingStepException();
        }

        [When("[action]")]
        public void WhenAction()
        {
            throw new PendingStepException();
        }

        [When("fill in valid values as following and click register button")]
        public async Task WhenFillInValidValuesAsFollowingAndClickRegisterButton(DataTable dataTable)
        {
            var data = dataTable.CreateInstance<RegisterData>();
            await _registerPage.Register(data.FirstName, data.LastName, data.PhoneNumber, 
                data.Country, data.EmailAddress, data.Password, data.Agree);
        }


        [Then("the backgound of the message should be green")]
        public async Task ThenTheBackgoundOfTheMessageShouldBeGreen()
        {
            throw new PendingStepException();
        }


        [Then("there is a successful message")]
        public async Task ThenThereIsSuccessfulMessage()
        {
            var message = await _registerPage.GetMessage();
            Assert.AreEqual("Successfully registered the following information", message);
        }


    }
}
