##Getting Started##

The solution contains two distinct applications, a web api project and a client project. The client project connects to the web api project and performs http calls which return data. 

You can run both projects at the same time in the solution file within visual studio. 

###Key Points###

- The web.config within the web api project does not contain a environment specific version. A web.release.config would be great for a build and release strategy in future state.  
