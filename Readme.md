## Getting Started ##

The solution contains two applications, a web api project and a client project. The client project connects to the web api project and performs http calls which return data. 

You can run both projects at the same time in the solution file within visual studio.

### Key Points ###

- The web.config within the solution does not contain a environment specific version. A web.release.config would be great for a build and release strategy in future state.

- The future proofing could use some work. Having models and services plugged into interfaces, then performing a registration is not fully completed in this implementation. Going thru this again, I would have used Asp.Net Core for ioc.

- The unit test only contains one test for the main function of the application. 
