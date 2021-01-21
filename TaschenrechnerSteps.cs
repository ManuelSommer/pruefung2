using System;
using TechTalk.SpecFlow;
using Xunit;

namespace XUnitTestProjectpruefung
{
    [Binding]
    public class TaschenrechnerSteps
    {
        [Given(@"the number is Pi")]
        public void GivenTheNumberIsPi()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the sinus of number")]
        public void WhenTheSinusOfNumber()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the cosinus of number")]
        public void WhenTheCosinusOfNumber()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the tangens of number")]
        public void WhenTheTangensOfNumber()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
