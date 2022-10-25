# MakingHttpRequest
The original and well-known HttpClient class can be easily used, but in some cases, it isn't being properly used by many developers. There are different issues that you can run into when instantiating and using the HttpClient class directly in your application code. You can run into multiple open connections, socket exhaustion, failure
to handle underlying DNS changes, etc. To address all these issues, .NET Core has the IHttpClientFactory interface that can be used to
configure and create HttpClient instances.

 I will walk you through the common mistakes that we run into when creating and managing HttpClient instances ourselves.
I will show how you netstat to inspect the underlying socket connections that are opened when we create HttpClient instances and how the code we write affects it. I will then show you how to fix those using the IHttpClientFactory and the different consumption patterns
available - Basic, Named, and Typed client instances.
