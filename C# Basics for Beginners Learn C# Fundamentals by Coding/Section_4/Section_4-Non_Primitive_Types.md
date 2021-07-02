# Classes

- Combines related Variables (fields) and functions (methods)

### Declaring Classes

example 1

```csharp
public class Person
{
    public string Name;

    // methods
    public void Introduce()
    {
        console.WriteLine("Hi, my name is " + Name);
    }
}
```

example 2

```csharp
public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}
```

### Creating Objects

```csharp
int number;
var person = new Person(); //you need to allocate memory to an object by using the new operator.
person.Name = "Amir";
person.Introduce();
```

### Static Modifier

```csharp
public class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
}

int result = Calculator.Add(1, 2);
```

when you add static, that modifier will be accessible through the class itself, not an object.

# Structs

### Declaring Structs

short for structures

```csharp
public struct RgbColor
{
    public int Red;
    public int Green;
    public int Blue;
}
```
99% of the time you will use a class not a struct.

 - Use a structure when you want to define a small lightweight object.

 # Arrays

### What is an Array
    - A data structure to store a collection of variables of the same type.
### Declaring Arrays
```csharp
int number 1;
int number 2;
int number 3;
// instead of declaring 3 different variables like above, you can declare and array like below.

int[] numbers = new int[3];
```
### Initializing Arrays
```csharp
int[] numbers = new int[3];
```

### Access Array Elements
```csharp
int[] numbers = new int[3];

numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;

```

# Strings

### What is a string?

- a sequence of characters

e.g. "Hello World"
### How to create strings

#### String Literals
```csharp
string firstName = "Amir";
```

#### String Concatenation
```csharp
string name = firstName + " " + lastName;
```

#### String Format
```csharp
string name = string.Format("{0} {1}", firstName, lastName);
```

#### String Join
```csharp
var numbers = new int[3] { 1, 2, 3 };

string list = string.Join(",", numbers);
```

### Strings are immutable
- once you create them, you cannot change them. 

### Escape characters and verbatim strings

| Char | Description |
| --- | --- |
| \n | New Line |
| \t | Tab |
| \\\ | Backslash |
| \\' | Single Quotation Mark |
| \\" | Double Quotation Mark |

### Verbatim Strings

```csharp
string path = "c:\\projects\\project1\\folder1";
// this is messy so instead we can add the @ sign like below

string path = @"c:\projects\project1\folder1";
```

# Enums

- A set of name/value pairs (constants).

```csharp
const int RegularAirMail = 1;
const int RegisteredAirMail = 2;
const int Express = 3;

public enum ShippingMethod
{
    RegularAirMail = 1,
    RegisteredAirMail = 2,
    Express = 3
}
```
Use enums where you have a number of related Constants
- instead of declaring multiple constants

#### Then you can use it with dot notation

```csharp
var method = ShippingMethod.Express;
```

# Reference Types and Value Types

| Structures | Classes | 
| --- | --- | 
|primitive types|Arrays|
|custom structures|Strings|
||custom classes|

- Value Types
    - Structures
        - allocated on stack
        - memory allocation done automatically
        - immediately removed when out of Scope

- Reference Types
    - Classes
        - You need to allocate memory
        - Memory allocated on heap
        - Garbage collected by CLR
