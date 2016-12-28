# Establishment
Establishment is a lightweight .Net input validation library based on whitelisting principles.

It encourages you to validate parameters before they're used in methods by establishing that their value falls within specific 
required ranges, lengths, and formats.

## NuGet
You can find Establishment on NuGet at https://www.nuget.org/packages/Establishment/

Or via the NuGet Package Manager Console:

`PM> Install-Package Establishment`

Its only prerequisite is .Net 4.6.1!

## Usage
Establishment is straightfoward and easy to use! Here's the quick details you need to get up and running.

### Add a using statement
Establishment uses a single namespace for everything, so just make sure to add the following using statement:
```csharp
using Establishment;
```

### Validating basic input parameters
Not that we've got our using statement out of the way, let's check out a simple example using `Establish` class to validate some input parameters.

```csharp
public void FindDocument(string title, string extension) {
    Establish.For(title).IsNotNullOrEmpty();
    Establish.For(extension).IsNotNullOrEmpty();
}
```

Here, we ensure that the supplied parameters `title` and `extension` are not null or empty before we use them.

### Chaining validation together
Each establishment validator can be chained together with other methods to create as narrow of a scope for the variable as you'd like.

```csharp
public void ValidatePhoneNumber(string phone) {
    Establish.For(phone).IsNotNullOrEmpty().HasMinimumLength(10).HasMaximumLength(14);
}
```

In this case before we do further validation on the supplied phone number, we ensure that the supplied parameter is not null, not empty, at least 10 characters in length, and at most 14 characters in length.

### Reference types
Establishment works just as well with custom objects and reference types.

```csharp
public bool UpdateUserStore(User user, IStoreContext context) {
    // establishes that neither the user or context parameters are null
    Establish.For(user).IsNotDefault(user);
    Establish.For(context).IsNotDefault(context);
    
    // Update the store
}
```

In this example if either the `user` or `context` parameters is null an `ArgumentNullException` will be thrown.

### Collections
Establishment works with objects that implement `IEnumerable<T>`as well.

```csharp
var intArray = new int[] { 1, 2, 3 };
Establish.For(intArray).IsNotNull().HasElements().HasMaximumLength(10);

var stringList = new List<string>() { };
Establish.For(stringList).IsNotNull().HasNoElements();
```

## Handling Failures
Each establishment method equates to a test from a provided value against a specific criteria or secondary value. In the event a validation method fails, by default, an `EstablishmentException` is thrown. Such as in this example:

```csharp
// input is null
public bool DoWork(string input) {
    Establish.For(input).IsNotNull(); // Will throw a new ArgumentException
}
```

However, in some cases you may want to throw your own exception or handle the failure in other ways. In these cases Establishment provides you a way to override this behavior.

### Overriding the default failure behavior
You can override the default behavior of throwing an exception in one of two ways:
By setting a global value in Establishment that will prevent exceptions from being thrown, as seen here:

```csharp
Establish.ThrowExceptionOnFailure = false;
```

Or by overriding the options specifically for an establisher instance:

```csharp
Establish.For("hello world", new EstablisherOptions() {
    ThrowExceptionOnFailure = false
});
```

In either case, when setting this variable to false you can check for failures by utilizing a pattern such as this:

```csharp
// input is null
public bool DoWork(string input) {
    if (Establish.For(input).IsNotNull().HasExceptions) {
        // Do some manual exception handling
    }
}
```

## Custom validation methods
Establishment also allows you to call your own validation methods via method delegates

### Action
```csharp
// Using an inline delegate we can check for a very specific condition that is outside of the
// scope of what the built-in methods check for
Establish.For("hello world").Satisfies(x => CustomValidationMethod(x));

// If the action throws an exception, the validation chain will fail
```

### Predicate
```csharp
// Using an inline delegate we can check for a very specific condition that is outside of the
// scope of what the built-in methods check for
Establish.For("hello world").Satisfies(x => x[0] == 'h');

// If the predicate returns false or throws an exception, validation chain will fail
```
