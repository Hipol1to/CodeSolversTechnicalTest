Feature: PostRequest

Scenario: Verify the JSONPlaceHolder page returns a 201 status code
	When user sends a post request to JSONPlaceHolder page
	Then the response status code is the expected
