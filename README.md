# NSwagScalarIssue

We have come across an issue where when utilizing an NSwag CLI-generated API client, an endpoint whose return type is simply a string is deserialized incorrectly; that is it appears with an escaped set of double quotes around the value.

This repository sets up the scenario with the following applications:


- Producer - This is the API for which an API client is generated.
- Consumer - The application that utilizes the NSwag-generated client to call the _Producer_ API.

## Expected Result

What we expect as the result from calling the API endpoint (via the ApiClient) is the value "Hello World".

## Actual Result

What we _actually_ get as the result is extra quotes around the value -- i.e. "\"Hello World\"".