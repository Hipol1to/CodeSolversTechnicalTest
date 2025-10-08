using System;
using Reqnroll;

namespace TestForCodeSolvers.StepDefinitions
{
    [Binding]
    public class PostRequestStepDefinitions
    {
        private HttpResponseMessage theResponse;
        private int theStatusCode;
        [When("user sends a post request to JSONPlaceHolder page")]
        public async Task WhenUserSendsAPostRequestToJSONPlaceHolderPage()
        {
            string endpointAddress = "/posts";
            HttpClient client = new()
            {
                BaseAddress = new Uri("https://jsonplaceholder.typicode.com")
            };
            StringContent request = new StringContent("pruebaa");
            var response = await client.PostAsync(endpointAddress, request);
            theResponse = response;
            theStatusCode = (int)response.StatusCode;
        }

        [Then("the response status code is the expected")]
        public void ThenTheResponseStatusCodeIsTheExpected()
        {
            theResponse.EnsureSuccessStatusCode();
            int currentStatusCodeNumber = theStatusCode;
            int expectedStatusCodeNumber = 201;

            Assert.AreEqual(expectedStatusCodeNumber, currentStatusCodeNumber);
        }
    }
}
