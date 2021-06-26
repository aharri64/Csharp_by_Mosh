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

# Scope

Scope determines where a value has meaning and is accessible. A variable has a scope in the
block it is defined and in any child blocks. But it is not accessible outside that block. A block is
indicated by curly braces ({ }).

```csharp
{
  byte a = 1;
  {
    byte b = 2;
    {
      byte c = 3;
    }
  }
}
```
# C# Operators

- Arithmetic Operators
  - use when working with numbers
  - increment
    - (++)
      - example: a++
      - same as: a = a + 1
  - decrement
    - (--)
      - example: a--
      - same as: a = a - 1
  - can use as postfix increment
  ```csharp
    int a = 1;
    int b = a++;
  ```
    - after the second line is executed, a = 2 and b = 1
  - can use as prefix
  ```csharp
    int a = 1;
    int b = ++a;
  ```
  - after the sexond line is executed, both a and b will = 2
- Comparison Operators
  - Equal  
    - ( == )
  - Not Equal
    - ( != )
  - Greater Than
    - ( > )
  - Greater than or equal to
    - ( >= )
  - less than
    - ( < )
  - less than or equal to
    - ( <= )
- Assignment Operators
  - Assignment
    - ( = )
  - Addition Assignment
    - ( += )
  - Subtraction Assignment
    - ( -= )
  - Multiplication Assignment
    - ( *= )
  - Division Assignment
    - ( /= )
- Logical Operators
  - And
    - &&
  - Or
    - ||
  - Not
    - !/
- Bitwise Operators
  - And
    - &
  - Or 
    - |

# Comments

- Single line comment
```csharp
// Here is a single-line comment
int a = 1;
```
- multi-line comments
```csharp
/*
Here is a multi-line
comment
*/
int a = 1;
```

## When to use
- To explain whys, hows, constraints, etc. not the whats.
