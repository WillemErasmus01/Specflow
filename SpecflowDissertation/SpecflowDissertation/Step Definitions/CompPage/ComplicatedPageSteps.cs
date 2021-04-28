using TechTalk.SpecFlow;
using SpecflowDissertation.Common;
using System.Threading;
using static SpecflowDissertation.Helpers.Webhelper;
/*
###################################################
refer to the comp page in the common folder for the 
explanation on the way this test is set up.

one improvement i could have made is by putting
everything into the same class, this would mean
i only need to declare navigation and comp once
     - the downside to this is that it might make 
    seperating the different tests a bit more tricky
###################################################
*/

namespace SpecflowDissertation.Step_Definitions
{

    [Binding]
    public class ComplicatedPageSteps
    {
        private readonly Navigation navigation = new Navigation();
        private readonly Comp comp = new Comp();

        [Given(@"I start this test")]
        public void GivenIStartThisTest()
        {
            navigation.navToComp();
        }
        
        [Then(@"I should navigate to the Complicated Page website")]
        public void ThenIShouldNavigateToTheComplicatedPageWebsite()
        {
            comp.waitForSelector("CompPage");
            endTest();
        }
    }
    [Binding]
    public class ComplicatedPageStepsFacebookButton
    {
        private readonly Navigation navigation = new Navigation();
        private readonly Comp comp = new Comp();

        [Given(@"i press the facebook button")]
        public void GivenIPressTheFacebookButton()
        {
            comp.buttonSelector("Facebook");
        }

        [Then(@"i should be redirected to facebook")]
        public void ThenIShouldBeRedirectedToFacebook()
        {
            comp.waitForSelector("Facebook");
            endTest();
        }
    }
    [Binding]
    public class ComplicatedPageStepsToggleButton
    {

        private readonly Navigation navigation = new Navigation();
        private readonly Comp comp = new Comp();
        [Given(@"i press the toggle button")]
        public void GivenIPressTheToggleButton()
        {
            comp.buttonSelector("Toggle");
        }

        [Then(@"i should see its contents")]
        public void ThenIShouldSeeItsContents()
        {
            comp.waitForSelector("Toggle");
            endTest();
        }
    }

    [Binding]
    public class ComplicatedPageStepsTwitterButton
    {
        private readonly Navigation navigation = new Navigation();
        private readonly Comp comp = new Comp();

        [Given(@"i press the twitter button")]
        public void GivenIPressTheTwitterButton()
        {
            comp.buttonSelector("Twitter");
        }

        [Then(@"i should be redirected to twitter")]
        public void ThenIShouldBeRedirectedToTwitter()
        {
            comp.waitForSelector("Twitter");
            endTest();
        }
    }
    [Binding]
    public class ComplicatedPagePushButton
    {

        private readonly Navigation navigation = new Navigation();
        private readonly Comp comp = new Comp();

        [Given(@"I am on the Complicated Page website")]
        public void GivenIAmOnTheComplicatedPageWebsite()
        {
            navigation.navToComp();
            comp.waitForSelector("CompPage");
        }

        [Given(@"I press a button")]
        public void GivenIPressAButton()
        {
            comp.buttonSelector("ButtonOne");
        }

        [Then(@"the page should refresh")]
        public void ThenThePageShouldRefresh()
        {
            comp.waitForSelector("Sidebar");
            endTest();
        }
    }
    [Binding]
    public class ComplicatedPageStepsLikeThis
    {
        private readonly Navigation navigation = new Navigation();
        private readonly Comp comp = new Comp();
        [When(@"i press the Like this button")]
        public void WhenIPressTheLikeThisButton()
        {
            comp.buttonSelector("LikeThis");
        }

        [Then(@"i should be moved to the bottom of the page")]
        public void ThenIShouldBeMovedToTheBottomOfThePage()
        {
            comp.waitForSelector("LikeThis");
            endTest();
        }
    }
    [Binding]
    public class ComplicatedPageStepsFooterButton
    {
        private readonly Navigation navigation = new Navigation();
        private readonly Comp comp = new Comp();
        [When(@"i press the Footer button underneath the search bar")]
        public void WhenIPressTheFooterButtonUnderneathTheSearchBar()
        {
            comp.buttonSelector("ClickFooters");
        }

        [Then(@"it would open the search page and show a link to the Complicated page")]
        public void ThenItWouldOpenTheSearchPageAndShowALinkToTheComplicatedPage()
        {
            comp.waitForSelector("ClickFooters");
            endTest();
        }
    }
    [Binding]
    public class ComplicatedPageStepsCorrectSearch
    {

        private readonly Navigation navigation = new Navigation();
        private readonly Comp comp = new Comp();

        [When(@"i click on the search bar")]
        public void WhenIClickOnTheSearchBar()
        {
            comp.buttonSelector("ClickSearch");
        }

        [When(@"enter the word ""(.*)""")]
        public void WhenEnterTheWord(string p0)
        {
            comp.enterKeysSelector("ClickSearch", p0);
        }

        [Then(@"it would search for anything with the word test in it")]
        public void ThenItWouldSearchForAnythingWithTheWordTestInIt()
        {
            comp.waitForSelector("CorrectResults");
            endTest();
        }
    }
    [Binding]
    public class ComplicatedPageStepsAmbiguousSearch
    {

        private readonly Navigation navigation = new Navigation();
        private readonly Comp comp = new Comp();

        [When(@"i enter the word ""(.*)""")]
        public void WhenIEnterTheWord(string p0)
        {
            comp.enterKeysSelector("IncorrectSearch", p0);
        }

        [Then(@"no results should be found")]
        public void ThenNoResultsShouldBeFound()
        {
            comp.waitForSelector("IncorrectResults");
            endTest();
        }
    }
}
