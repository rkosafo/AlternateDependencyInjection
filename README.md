# AlternateDependencyInjection
An attempt to separate interfaces and implementations for asp.net application

## Motivation
Modern DI includes wonderful things like 
- Constructor Injection
- Property Injection
- etc

## Attempt 1
- Create Interface for the service
- Create a static class that implements the needed functions on the interface
- To use the service, just use the functions defined on the static service class
- On init, set the implementation that static service should use


## Attempt 2
- Starts off like attempt 1 but instead of exposing the functions on the static class, the interface is rather exposed.
  This has the benefit of reducing the amount of coding needed to expose the service
- Using the singleton pattern, introduce a **shared** or **singleton** property that exposes the implementation
- Add a fatory function that can create instances if needed


# Questions
- Will lazy help here?
