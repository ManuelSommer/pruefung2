using System;
using TechTalk.SpecFlow;
using Xunit;

namespace pruefung
{
    [Binding]
    public class TaschenrechnerSteps
    {
        private double number, result;
        [Given(@"the number is Pi")]
        public void GivenTheNumberIsPi()
        {
            number = Math.PI;
        }

        [When(@"the sinus of number")]
        public void WhenTheSinusOfNumber()
        {
            result = Math.Sin(number);
        }

        [When(@"the cosinus of number")]
        public void WhenTheCosinusOfNumber()
        {
            result = Math.Cos(number);
        }

        [When(@"the tangens of number")]
        public void WhenTheTangensOfNumber()
        {
            result = Math.Tan(number);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.Equal(p0, result, 5);
        }
    }
}