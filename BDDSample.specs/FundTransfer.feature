Feature: Customer Transfer's Fund
       As a customer,
       I want to transfer funds
       so that I can send money to my friends and family

@validpayee
Scenario: valid payee
	Given the user is on Fund Transfer Page When he enters "mary" as payee name
	And he enters "5000" as amount
	And he Submits request for Fund Transfer
	Then ensure the fund transfer is complete with "$100 transferred successfully to mary!!" message

@invalidpayee
Scenario: invalid payee
	Given the user is on Fund Transfer Page
	When he enters "Jack" as payee name
	And he enters "100" as amount
	And he Submits request for Fund Transfer
	Then ensure a transaction failure message "Transfer failed!! 'Jack' is not registered in your List of Payees" is displayed
 
@overdrawnaccount
Scenario: Account is overdrawn past the overdraft limit
	Given the user is on Fund Transfer Page
	When he enters "Tim" as payee name
	And he enters "1000000" as amount
	And he Submits request for Fund Transfer
	Then ensure a transaction failure message "Transfer failed!! account cannot be overdrawn" is displayed
 