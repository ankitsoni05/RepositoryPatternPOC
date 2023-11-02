**Middlewares VS Filters**

Both are used to add additional logic to HTTP request pipeling.

1. Filters are used to add functionality that is specific to an action method or controller, whereas middleware is used to add functionality that is applied to all       requests passing through the pipeline.
2. Filters are executed in a specific order, based on their type (authorization filters, action filters, result filters, etc.), whereas middleware is executed in the     order it is added to the pipeline.
3. Filters can access and modify the action context and arguments, whereas middleware can only modify the HTTP context.
4. There are many built-in filters in .NET Core, such as authorization filters, action filters, exception filters, and resource filters, but middleware is more           flexible and allows developers to create their own custom middleware.

**In general, if you need to add functionality that is specific to a controller or action method, then filters may be the best choice. If you need to add functionality that applies to all requests passing through the pipeline, then middleware may be the best choice.**


![image](https://github.com/ankitsoni05/RepositoryPatternPOC/assets/17673742/dd542247-aacd-484b-8c7b-3b79ec9dd3af)

![image](https://github.com/ankitsoni05/RepositoryPatternPOC/assets/17673742/b20962b7-fe71-44b6-9ae2-a5cd5e940f51)


When to Use Filters ?
1. **Authorization**: we can use an authorization filter to verify that a user is authorized to access a particular action method or controller.
2. **Caching**: we can use a caching filter to cache the response of an action method, so that subsequent requests can be served faster.
3. **Logging**: we can use a logging filter to log information about each request and response.
4. **Validation**: we can use a validation filter to validate the input to an action method, to ensure that it meets certain criteria.
5. **Exception handling**: we can use an exception filter to catch exceptions thrown by an action method and handle them appropriately.

When to Use Filters ?
1. **CORS**: we can use middleware to add CORS (Cross-Origin Resource Sharing) support to your application, so that it can be accessed from other domains.
2. **Static files**: we can use middleware to serve static files, such as HTML, CSS, and JavaScript files, from your application.
3. **Compression**: we can use middleware to compress the response of an HTTP request, to reduce the amount of data that needs to be transferred.
4. **Authentication**: we can use middleware to handle user authentication, such as verifying user credentials and creating authentication tokens.
