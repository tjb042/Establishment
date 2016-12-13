# Establishment
Establishment is a lightweight .Net input validation library based on whitelisting principles.

It encourages you to validate parameters before their used in methods by establishing that their value falls within specific 
required ranges, lengths, and formats.

## NuGet
You can Establishment on NuGet at https://www.nuget.org/packages/Establishment/

Or via the NuGet Package Manager Console:

`PM> Install-Package Establishment`

## Usage
Establishment is straightfoward and easy to use! Here are a few basic examples to get you started:

### Using the static Establish class
The static class `Establishment.Establish` contains default establishers for most common and primitive types.

Here's an example using the string establisher:
```csharp
using Establishment;

public bool UpdateUserStore(User user, IStoreContext context) {
    // establishes that neither the user or context parameters are null
    Establish.Object.IsNotNull(user);
    Establish.Object.IsNotNull(context);
    
    // Update the store
}
```

In this example if either the `user` or `context` parameters is null an `ArgumentNullException` will be thrown.
