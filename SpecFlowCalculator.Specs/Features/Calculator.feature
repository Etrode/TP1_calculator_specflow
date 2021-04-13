Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowCalculator.Specs/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@addition
Scenario Outline: Add two numbers
	Given the first number is <first>
	And the second number is <second>
	When the two numbers are added
	Then the result should be <result>

    Examples:
    | first | second | result |
    |    50 |   70   |    120   |
    |    5 |   5     |   10   |

@substraction
Scenario Outline: Subtract two numbers
	Given the first number is <first>
	And the second number is <second>
    When the two numbers are subtracted
    Then the result should be <result>

    Examples:
    | first | second | result |
    |    50 |   20   |    30   |
    |    5 |   5     |   0   |


@multiplication
Scenario Outline: Multiply two numbers
	Given the first number is <first>
	And the second number is <second>
    When the two numbers are multiplied
    Then the result should be <result>

    
    Examples:
    | first | second | result |
    |    120 |   70   |    8400   |
    |    5 |   5     |   25   |

@division
Scenario Outline: Divide two numbers
	Given the first number is <first>
	And the second number is <second>
    When the two numbers are divided
    Then the result should be <result>

    Examples:
    | first | second | result |
    |    50 |   0   |    0   |
    |    5 |   5     |   1   |
