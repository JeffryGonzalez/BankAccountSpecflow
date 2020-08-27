Feature: CreatingANewAccount
	In order do some banking
	As a bank customer
	I want to create a new account

@feature
Scenario: Creating a new Account
	Given I have created a new Bank Account
	When I retrieve the balance
	Then the balance should be "1000.00"