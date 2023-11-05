**REST :- Representational State Transfer**
Rest is Architectural Design style for designing client-server Styled application.

**Architectural Constraints of REST.**
There are 6 constraints on the basis of rest is designed.

**1. uniform Interface :- **
It is a key constraint that differentiate between a REST API and Non-REST API. It suggests that there should be an uniform way of interacting with a given server irrespective of device or type of application (website, mobile app). 

![image](https://github.com/ankitsoni05/RepositoryPatternPOC/assets/17673742/f3efad03-4a30-4480-9e39-f23eb52d3cfe)


4 guidelines of Uniform Interface.
1. Resource-Based: Individual resources are identified in requests. For example: API/users.
2. Manipulation of Resources Through Representations: Client has representation of resource and it contains enough information to modify or delete the resource on the server, provided it has permission to do so. Example: Usually user get a user id when user request for a list of users and then use that id to delete or modify that particular user.
3. Self-descriptive Messages: Each message includes enough information to describe how to process the message so that server can easily analyses the request.
4. Hypermedia as the Engine of Application State (HATEOAS): It need to include links for each response so that client can discover other resources easily.

**2. Stateless.**
- Make all client-server interactions stateless.
- The server will not store anything about the latest HTTP request the client made.
- It will treat every request as new. No session, no history.
- If the client application needs to be a stateful application for the end-user, where the user logs in once and does other authorized operations after that, then each request from the client should contain all the information necessary to service the request – including authentication and authorization details.
**Summary :-** No client context shall be stored on the server between requests. The client is responsible for managing the state of the application.

![image](https://github.com/ankitsoni05/RepositoryPatternPOC/assets/17673742/4c6efd47-5e20-47ad-bea3-558c45fa2776)


**3. Cacheable.**
- Every response should include whether the response is cacheable or not and for how much duration responses can be cached at the client side.
- Client will return the data from its cache for any subsequent request and there would be no need to send the request again to the server.
- A well-managed caching partially or completely eliminates some client–server interactions, further improving availability and performance.
- Sometime there are chances that user may receive stale(Old) data.

![image](https://github.com/ankitsoni05/RepositoryPatternPOC/assets/17673742/cf0750b3-28ad-4d3d-86e8-ccc8670f9728)


**4. Client–server**
- This constraint essentially means that client applications and server applications MUST be able to evolve separately without any dependency on each other.
- A client should know only resource URIs, and that’s all.
- Today, this is standard practice in web development, so nothing fancy is required from your side. Keep it simple.

![image](https://github.com/ankitsoni05/RepositoryPatternPOC/assets/17673742/03e5a537-1181-44a1-a489-4a6a8c471343)


**5. Layered system**
- An application architecture needs to be composed of multiple layers.
- Each layer doesn’t know any thing about any layer other than that of immediate layer and there can be lot of intermediate servers between client and the end server.
- Intermediary servers may improve system availability by enabling load-balancing and by providing shared caches.

![image](https://github.com/ankitsoni05/RepositoryPatternPOC/assets/17673742/0b2bcc3b-d46c-4db1-96f9-f4d605381c20)


**6. Code On Demand (COD)**
- It is an optional feature.
- According to this, servers can also provide executable code to the client.
- The examples of code on demand may include the compiled components such as Java Servlets and Server-Side Scripts such as JavaScript.

![image](https://github.com/ankitsoni05/RepositoryPatternPOC/assets/17673742/6c9442fb-06e1-46e1-83c2-69d5b9059a1a)


**HTTP Verbs**
1. **GET**: Retrieves one or more resources identified by the request URI and it can cache the information receive.
2. **POST**: Create a resource from the submission of a request and response is not cacheable in this case. This method is unsafe if no security is applied to the endpoint as it would allow anyone to create a random resource by submission.
3. **PUT**: Update an existing resource on the server specified by the request URI.
4. **DELETE**: Delete an existing resource on the server specified by the request URI. It always return an appropriate HTTP status for every request.
5. **GET, PUT, DELETE** methods are also known as Idempotent methods. Applying an operation once or applying it multiple times has the same effect. Example: Delete any resource from the server and it succeeds with 200 OK and then try again to delete that resource than it will display an error message 410 GONE.

