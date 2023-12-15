Feature: Messages
A "Messages" form on the website

@tag1
Scenario: Everything is entered correctly
	Given The user enters the Messages site
	And he enters the name "Karel"
	And he enters the email "karel@karel.cz"
	And he enters the "Ahoj" message
	When he clicks the Create button
	Then the success message should be displayed
	And He can close the browser

Scenario: Forgot to enter e-mail
	Given The user enters the Messages site
	And he enters the name "Ivo"
	But he forgots to enter the e-mail
	And he enters the "Čau" message
	When he clicks the Create button
	Then the e-mail error should be displayed
	And He can close the browser
