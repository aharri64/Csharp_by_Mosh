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
