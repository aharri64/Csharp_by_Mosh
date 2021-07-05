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
