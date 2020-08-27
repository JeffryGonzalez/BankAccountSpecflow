Feature: DeposingMoney
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Adding Money to My Account
	Given I have created a new Bank Account
	When I retrieve the balance
	And I deposit "100"
	Then the balance should be "1100.00"

Scenario: Adding Money With a Negative Value
	Given I have created a new Bank Account
	When I retrieve the balance
	And I deposit "-50.00"
	And the balance is not changed.





