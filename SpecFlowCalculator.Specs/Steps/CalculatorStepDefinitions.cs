using TechTalk.SpecFlow;
using FluentAssertions;
using System.Collections.Generic;

namespace SpecFlowCalculator.Specs.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        private readonly Calculator _calculator = new Calculator();

        private int _result;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"the following numbers")]
        public void GivenTheFollowingNumbers(Table table)
        {
            List<int> inputsNumbers = new List<int>();
            foreach(TableRow row in table.Rows)
            {
                int value = int.Parse(row[0]);
                inputsNumbers.Add(value);
            }
            _calculator.InputsNumbers = inputsNumbers;
        }

        [When(@"the numbers are added")]
        public void WhenTheNumbersAreAdded()
        {
            _result = _calculator.Add();
        }

        [When(@"the numbers are subtracted")]
        public void WhenTheNumbersAreSubtracted()
        {
            _result = _calculator.Sub();
        }

        [When(@"the numbers are multiplied")]
        public void WhenTheNumbersAreMultiplied()
        {
            _result = _calculator.Multiply();
        }

        [When(@"the numbers are divided")]
        public void WhenTheNumbersAreDivided()
        {
            _result = _calculator.Divide();
        }

        [Given(@"the following numbers and operators")]
        public void GivenTheFollowingNumbersAndOperators(Table table)
        {
            List<int> inputsNumbers = new List<int>();
            List<string> operators = new List<string>();
            bool first = true;
            foreach (TableRow row in table.Rows)
            {
                int value = int.Parse(row[0]);
                inputsNumbers.Add(value);

                if (first) { first = false; }
                else
                {
                    string operat = row[1];
                    operators.Add(operat);
                }
            }
            _calculator.InputsNumbers = inputsNumbers;
            _calculator.Operators = operators;
        }

        [When(@"the numbers are calculated")]
        public void WhenTheNumbersAreCalculated()
        {
            _result = _calculator.Calculate();
        }


        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _result.Should().Be(result);
        }
    }
}
