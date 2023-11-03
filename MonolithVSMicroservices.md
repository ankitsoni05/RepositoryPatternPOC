**Monolithic VS Microservices.**

**What is a Monolith?**
Monolith is an application where everything works as one piece of code, it starts every project either API or Frontend, and usually we end up with one executable in one repository.
Your application is then developed, deployed, and scaled as one component.
As a team working on the same application, we need to make sure that we don’t step on each other's toes.


**Advantages of Monolithic **
1.  Very easy to develop, as we have one code base we don’t need to check a lot of more repositories.
2.  When it comes to test applications we have only 1 application to worry about.
3.  It will be a lot quicker to get into the market because of simplicity.
4.  Easy to deploy because only 1 CI/CD and 1 in fracture to worry about.
5.  Debugging will be a lot easier because as we run 1 application if we run multiple apps we need to make sure many things like they run on different ports.
	
**Disadvantages of Monolith.**
1. This creates an application very big fat and complex as it grows, every developer starts with the intention of clean code design, etc., but as it grows it starts to look messy and eventually hard to maintain.
2. The release process will take too long, because of a lot of features that need to through tested before moving to the server.
3. They are very difficult to scale, If one part of your application is getting a lot of traffic, we have no choice but to scale up the whole application., it's going to cost you a lot of money as a full application (one fat) needs to be scaled.


 **After looking as the disadvantages we need to have some solution and here is microservices comes in**


 **What are Microservices?**

We take a big monolith and break it down into small components, and each component has a single responsibility and is usually in charge of a single business functionality.
Let's consider Netflix, it might have 1 component in charge of the search, and 1 in charge of streaming videos and another in charge of recommendations.

If we split into microservices, how are they going to talk to each other?

**Microservices Communication**

**There are 3 ways:- ** 
1. API:- each microdevice has endpoints that other microservices can call, this should be when we need synchronous communication between components. Microservices usually also have health endpoints so we can ping them to check if they are still operational, as with all HTTP requests it will introduce some latency into your application that we need to take into account, however, we can use GRPS or compression to speed up the communication.
2. Message Broker:- if an application needs to communicate asynchronously then a message broker could be the best solution, there are a lot queue queue-based technologies available to use for this purpose, the more popular one 1 rabbit mq.
3. Service mesh 

**Advantages of Microservices **
1. A well-designed microservices is responsible for 1 thing as a result they are a lot easier to maintain, In many cases we event not need to touch the microservices.
2. In Monolith as we need to deploy the whole application we might end up breaking other parts of the application, but in the case of microservices we just need to make changes to the component responsible for that functionality and will require only deployment of the single responsible component, in short the other microservices aren't affected, this makes system reliable and changes of whole system crashing down is less with failure in 1 component. For example, let's consider GitHub If we look at the status of GitHub functionalities whole system never comes down, some functionalities might be only affected at a time let's say web hooks are down.
3. Each team can pick its own technology stack, which can be a bit of a blessing,
4. Scalability:- As one part of our application is getting more traffic we have the opportunity to just scale that one specific service.

**Disadvantages of Microservices**
1. If microservices are highly dependent on others to work then it will be very difficult to run our application locally, we could either resort to mocking out the other endpoints, or we have to spin up the docker container for all of the other microservices, this can be done but became bit harder than running a single application.
2. Hard to Debug.
3. Lastly microservices increase the complexity of your whole system, like multiple CI/CD, infra we need to worry about communications, etc.
4. We need to have very good monitoring in place just to make sure or track what our microservices are doing.
	
	
**Which one should you be using in your next project?**
1. If you are starting a new project that is not going into an existing infrastructure then I would recommend going with monolith.
2. If we are looking into an existing workflow then we can start using microservices for your project.
