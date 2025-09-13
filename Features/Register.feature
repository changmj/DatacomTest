Feature: Register

Testing Register feature

Background: 
	Given open the register page

Rule: Verify the apperence of the form page


	@E2E
	Scenario: Verify the labels, styles, placehoders and help text of each feild
		Then The Labels, styles, placehoders and help text of each feild should looks like as below:
		| field name    | required | help text                                   |
		| First Name    | true     |                                             |
		| Last Name     | true     |                                             |
		| Phone number  | true     | Phone length validation: at least 10 digits |
		| Country       | true     |                                             |
		| Email address | true     |                                             |
		| Password      | true     | Psw length validation: [6,20] characters    |

	@E2E
	Scenario: The check box for the agreement of terms and conditions should be able to editable
		Then The check box for the agreement of terms and conditions should be able to editable

	@E2E
	Scenario: Should be able to open terms and conditions
		Then there should a link on the field to open the terms and conditions

	@E2E
	Scenario: Password should be displayed as hidden text
		Then Password should be displayed as hidden text

	@E2E
	Scenario: Should have confirm Password field to compare with the characoters in password field
		Then Should have confirm Password field

	@E2E
	Scenario: Veirfy drop down items of drop down List (each item should have unique value and text)
		Then each drop down item should have unique value and text


Rule: Verify the valication if each field

	Background: 
		Given input valid data to all of the fields (Note: except term check box. It's blocked by a defect)


	@E2E
	Scenario: Veirfy the empty input of each input field
		When I change the value in following field to empty
		And click the register button
		Then [outcome]

	@E2E
	Scenario: Veirfy the empty string of each input field
		Given [context]
		When [action]
		Then [outcome]

	@E2E
	Scenario: Veirfy the input type of each input field
		Given [context]
		When [action]
		Then [outcome]

	@E2E
	Scenario: Veirfy the max length of each input field
		Given [context]
		When [action]
		Then [outcome]

	@E2E
	Scenario: Veirfy the value of select control
		Given [context]
		When [action]
		Then [outcome]

	@E2E
	Scenario: Veirfy the value of check box control
		Given [context]
		When [action]
		Then [outcome]


Rule: Verify the form commit action

	@E2E
	Scenario: Verify the massage and style 
		When fill in valid values as following and click register button
		| FirstName | LastName | PhoneNumber | Country     | EmailAddress        | Password | Agree |
		| John      | Li       | 0243334456  | New Zealand | John.Li@hotmail.com | 123456   | ture  |
		Then the backgound of the message should be green

	@E2E
	Scenario: Verify the data is correct saved
		When fill in valid values as following and click register button
		| FirstName | LastName | PhoneNumber | Country             | EmailAddress        | Password | Agree |
		| John      | Li       | 0243334456  | New Zealand         | John.Li@hotmail.com | 123456   | ture  |

		Then there is a successful message




