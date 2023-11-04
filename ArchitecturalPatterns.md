**Software Architectural Patterns.**

**Definition :- ** The software architecture of a system represents the design decisions related to overall system structure and behavior.
The software Architecture refers to how you organize stuff in the process of creating software. And "Stuff" here can refer to:-

- **Implementation details** (that is, the folder structure of your repo)
- **Implementation design** decisions (Do you use server side or client side rendering? Relational or non-relational databases?)
- **The technologies you choose** (Do you use REST or GraphQl for your API? Python with Django or Node with Express for your        back end?)
- **System design decisions** (like is your system a monolith or is it divided into microservices?)
- **Infrastructure decisions** (Do you host your software on premise or on a cloud provider?)

**Below, are the list of Architectural Patterns and their use cases and their respective Drawbacks :-**

**1. Layered Pattern**
Intent :- Layers architecture is about dividing concerns and responsibilities into different folders and files, and allowing direct communication only between certain folders and files.

![image](https://github.com/ankitsoni05/RepositoryPatternPOC/assets/17673742/e58e50ea-5af9-4add-a71f-4da877853143)

![image](https://github.com/ankitsoni05/RepositoryPatternPOC/assets/17673742/1feffdb6-1832-4205-84e7-37e881cc861b)

Use Cases:- 

- E-commerce Platform: Separates user interface, business logic, and data storage for efficient management and updates.
- Banking Application: Ensures clear separation between customer interactions, transaction processing, and data storage.

Drawbacks:- 

- Communication between the layers can impact performance.
- Tight Coupling risks if layer boundries aren't well defined.
- May become more complex with more layers.

**2. Client-Server Pattern**

Intent :- Separates application into clients (user interfaces) and servers (data processing) to manage data sharing and user interactions. Ideal for distributed systems like web-based services.

![image](https://github.com/ankitsoni05/RepositoryPatternPOC/assets/17673742/81347107-e2cf-4bb9-a4c3-30041f93fdd0)

Use Cases:- 
- Email System: Allows clients to send requests for retrieving or sending emails to a central server.
- Online Gaming: Clients interact with a central server for real-time game updates and multiplayer interactions.
- Remote File Storage: Clients access a server to store and retrieve files securely from a remote location.

Drawbacks:- 
- Server scalability challenges during heavy traffic periods.
- Complex communication management between clients and server.
- Potential single point of failure if the server goes down.

**3. Microservices Pattern**

intent :- Structures applications as a collection of small, independently deployable services, enabling scalability and rapid development. Common in cloud-based systems.

![image](https://github.com/ankitsoni05/RepositoryPatternPOC/assets/17673742/c52b35db-3c37-4a5b-ae37-593a1c59f7e0)

Use Cases:- 
- E-commerce Marketplace: Different microservices handle user management, product catalog, payments, and order processing.
- Ride-Sharing Application: Separate services manage user authentication, ride requests, driver tracking, and payments.
- Streaming Platform: Microservices for content delivery, user profiles, recommendations, and billing.

Drawbacks:- 
- Complexity in managing distributed architecture.
- Challenges in ensuring data consistency across services.
- Communication overhead between services can impact performance.
