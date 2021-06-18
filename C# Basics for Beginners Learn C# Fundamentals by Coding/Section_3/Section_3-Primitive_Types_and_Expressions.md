# Variables and Constants

- Variable:
  - a name given to a storage location in memory.
- Constant:
  - an immutable value

### Declaring Variables / DefineConstants

start by declaring a type (int)

then by declaring an identifier (number)

```csharp
int number;
int Number = 1;
const float Pi = 3.14f;
```

### Identifiers

- Cannot start with a number
  - ex: 1route
  - Correct: oneSpace
- Cannot include whitespace
  - ex: first name
  - correct: firstName
- Cannot be a reserved keyword
  - ex: int
- use meaningful names
  - firstName not fn

### Nameing Conventions

- Camel Case: firstName
- Pascal Case: FirstName
- Hungarian Notation: strFirstName

  - hungarian notation is not used in C#

- For local variables: CamelCase - int number;
- For constants: Pascal Case - const int MaxZoom = 5;

### Non-Primative Types

- String
- Array
- Enum
- class

# Overflowing

Each type, depending on the number of types allocated to it, can store a range of values. If we store a value in a variable, but that value exceeds the boundary of values for the underlying type, overflow happens. For example, we can store any values between 0 and 255 in a byte. If the value of a byte exceeds this boundary during computations, overflow happens. Here is an
example:

```csharp
byte b = 255;
b = b + 1;
```

As a result of the second line, the value of b will be 0.

if you want to avoid this, you need to use the checked keyword.

```csharp
checked
{
byte b = 255;
b = b + 1;
}
```

an exception will be thrown.
