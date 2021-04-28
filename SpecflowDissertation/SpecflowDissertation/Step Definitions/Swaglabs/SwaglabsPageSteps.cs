using TechTalk.SpecFlow;
using SpecflowDissertation.Common;
using System.Threading;
using static SpecflowDissertation.Helpers.Webhelper;

/*
###################################################



###################################################
*/

namespace SpecflowDissertation.Step_Definitions.Swaglabs
{
    [Binding]
    public class SwaglabsPageSteps
    {
        private readonly Navigation navigation = new Navigation();
        private readonly Swaglab swaglab = new Swaglab();

        [Given(@"i start the swaglabs test")]
        public void GivenIStartTheSwaglabsTest()
        {
            navigation.navToSWAGLABS();
        }
        
        [Given(@"i am on the swaglabs login page")]
        public void GivenIAmOnTheSwaglabsLoginPage()
        {
            navigation.navToSWAGLABS();
            swaglab.verifyLoginPage();
        }
        
        [Given(@"i enter the invalid username ""(.*)"" and the correct password for all users which is ""(.*)""")]
        public void GivenIEnterTheInvalidUsernameAndTheCorrectPasswordForAllUsersWhichIs(string p0, string p1)
        {
            swaglab.performLogin(p0, p1);
        }
        
        [Given(@"i enter the username ""(.*)"" and ""(.*)"" which is an invalid password")]
        public void GivenIEnterTheUsernameAndWhichIsAnInvalidPassword(string p0, string p1)
        {
            swaglab.performLogin(p0, p1);
        }
        
        [Given(@"i enter the username ""(.*)"" and the password ""(.*)""")]
        public void GivenIEnterTheUsernameAndThePassword(string p0, string p1)
        {
            swaglab.performLogin(p0, p1);
        }
        
        [Given(@"i am logged in to the swaglabs page with the username ""(.*)"" and the password ""(.*)""")]
        public void GivenIAmLoggedInToTheSwaglabsPageWithTheUsernameAndThePassword(string p0, string p1)
        {
            navigation.navToSWAGLABS();
            swaglab.verifyLoginPage();
            swaglab.performLogin(p0, p1);
            swaglab.verifyLogin("validLogin");
        }
        
        [Given(@"i click on an item")]
        public void GivenIClickOnAnItem()
        {
            swaglab.clickItem();
        }
        
        [Given(@"i add an item to my kart")]
        public void GivenIAddAnItemToMyKart()
        {
            swaglab.addToCart();
        }
        
        [Given(@"i have an item in my kart")]
        public void GivenIHaveAnItemInMyKart()
        {
            swaglab.addToCart();
            swaglab.verifyCart();
        }
        
        [Given(@"i go to check it out")]
        public void GivenIGoToCheckItOut()
        {
            swaglab.verifyCart();
        }
        
        [When(@"i have an empty field")]
        public void WhenIHaveAnEmptyField()
        {
            swaglab.emptyFieldPurchase();
        }
        
        [Then(@"i should automatically navigate to the swaglabs website")]
        public void ThenIShouldAutomaticallyNavigateToTheSwaglabsWebsite()
        {
            swaglab.verifyLoginPage();
            endTest();
        }
        
        [Then(@"i should be able to login with the username ""(.*)"" and the password ""(.*)""")]
        public void ThenIShouldBeAbleToLoginWithTheUsernameAndThePassword(string p0, string p1)
        {
            swaglab.performLogin(p0, p1);
            swaglab.verifyLogin("validLogin");
            endTest();
        }
        
        [Then(@"i should not be able to login")]
        public void ThenIShouldNotBeAbleToLogin()
        {
            //swaglab.performLogin(p0, p1);
            swaglab.verifyLogin("invalidLogin");
            endTest();
        }
        
        [Then(@"i should not be able to login as the user is locked out")]
        public void ThenIShouldNotBeAbleToLoginAsTheUserIsLockedOut()
        {

            swaglab.verifyLogin("invalidLogin");
            endTest();
        }
        
        [Then(@"i should not be able to see any of the product images as this user has a problem")]
        public void ThenIShouldNotBeAbleToSeeAnyOfTheProductImagesAsThisUserHasAProblem()
        {
            swaglab.verifyBrokenUser();
            endTest();
        }
        
        [Then(@"i should be able to logout")]
        public void ThenIShouldBeAbleToLogout()
        {
            swaglab.Hamburger();
            swaglab.logout();
            endTest();
        }
        
        [Then(@"i should be moved to a page with more information on it")]
        public void ThenIShouldBeMovedToAPageWithMoreInformationOnIt()
        {
            swaglab.viewItem();
            endTest();
        }
        
        [Then(@"i should be able to add an item to the kart")]
        public void ThenIShouldBeAbleToAddAnItemToTheKart()
        {
            swaglab.addToCart();
            swaglab.verifyCart();
            endTest();
        }
        
        [Then(@"i should be able to remove it")]
        public void ThenIShouldBeAbleToRemoveIt()
        {
            swaglab.removeItem();
            endTest();
        }
        
        [Then(@"i should be able to view it")]
        public void ThenIShouldBeAbleToViewIt()
        {
            swaglab.verifyCart();
            endTest();
        }
        
        [Then(@"i should be able to purchase it")]
        public void ThenIShouldBeAbleToPurchaseIt()
        {
            swaglab.verifyCart();
            swaglab.purchaseItem();
            endTest();
        }
        
        [Then(@"i should be prompted that it is empty")]
        public void ThenIShouldBePromptedThatItIsEmpty()
        {
            swaglab.emptyFieldPrompt();

            endTest();
        }
        
        [Then(@"i should be able to reset the app state")]
        public void ThenIShouldBeAbleToResetTheAppState()
        {
            swaglab.Hamburger();
            swaglab.resetState();
            endTest();
        }
        
        [Then(@"i should be able to navigate to the About page")]
        public void ThenIShouldBeAbleToNavigateToTheAboutPage()
        {
            swaglab.Hamburger();
            swaglab.aboutHamburger();
            endTest();
        }
    }
}
