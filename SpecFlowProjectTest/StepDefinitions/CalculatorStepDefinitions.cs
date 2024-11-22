namespace SpecFlowProjectTest.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private int num1;
        private int num2;
        private int total;

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            num1 = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            num2 = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            total = num1 + num2;
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            total.Should().Be(result);
        }
    }
}