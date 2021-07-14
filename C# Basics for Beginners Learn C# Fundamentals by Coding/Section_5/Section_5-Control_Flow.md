# Conditional Statements

### If / Else Statements

#### **Basic Structure**

```csharp
if (condition)
    someStatement

else if (anotherCondition)
    anotherStatement

else
    yetAnotherStatement
```

**If there is more than one line of code after if or else, there must be curly braces**

```csharp
if (condition)
{
    someStatement
}
else
{
    anotherStatement
}
```

**We can also nest if statements inside each other**

```csharp
if (condition)
{
    if (anotherCondition)
    ...
    else
    ...
}
```

### Switch / Case Statements

```csharp
switch(role)
{
    case Role.Admin:
        ...
        break;
    case Role.Moderator:
        ...
        break;
    default:
        ...
        break;
}
```

### Conditional Operator: a ? b : c

# Iteration Statements

### For Loops

initialization clause

- var i = 0

condition clause

- i < 10

Iteration clause

- i++

```csharp
for (var i = 0; i < 10; i++)
{
    ...
}
```

### Foreach Loops

```csharp
foreach (var number in numbers)
{
    ...
}
```

### While Loops

```csharp
while (i < 10)
{
    ...
    i++;
}
```

### Do-While Loops

```csharp
do
{
    ...
    i++;
} while (i < 10);
```

- break
  - jumps out of the loop
- continue
  - jumps into the next iteration
