Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowCalculator.Specs/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@addition
Scenario: Add N numbers
	Given the following numbers
    | Numbers |
    | 25      |
    | 2       |
    | 10      |
	When the numbers are added
	Then the result should be 37

@substraction
Scenario: Subtract N numbers
	Given the following numbers
    | Numbers |
    | 25      |
    | 2       |
    | 10      |
	When the numbers are subtracted
	Then the result should be 13

@multiplication
Scenario: Multiply N numbers
	Given the following numbers
    | Numbers |
    | 20      |
    | 2       |
    | 3       |
	When the numbers are multiplied
	Then the result should be 120

@division
Scenario: Divide N numbers
	Given the following numbers
    | Numbers |
    | 90      |
    | 3       |
    | 2       |
	When the numbers are divided
	Then the result should be 15