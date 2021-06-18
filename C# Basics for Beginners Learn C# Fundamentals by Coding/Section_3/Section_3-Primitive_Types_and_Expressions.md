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
