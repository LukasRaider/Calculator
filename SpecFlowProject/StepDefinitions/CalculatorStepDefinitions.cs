namespace SpecFlowProject.StepDefinitions {
    [Binding]
    public sealed class CalculatorStepDefinitions {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        Calc calculator = new Calc();
        int a; 
        int b;
        int controlResult;
        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number) {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

           a=number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number) {
            //TODO: implement arrange (precondition) logic

            b=number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded() {
            //TODO: implement act (action) logic

            controlResult = calculator.Add(a, b);
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result) {
            //TODO: implement assert (verification) logic

            Assert.AreEqual(result, controlResult);
        }
        [When(@"the second number is subtracted from the first")]
        public void WhenTheSecondNumberIsSubtractedFromTheFirst() {
            controlResult = calculator.Substract(a, b);
        }

    }
}