# Working with Text

## Strings

### Useful String Methods

#### Formatting

- ToString()
  - "hello world"
- ToUpper()
  - "HELLO WORLD"
- Trim()
  - Get's rid of white spaces

#### Searching

- IndexOf('a')
- LastIndexOf("Hello")

#### Substrings

- Substring(startIndex)
- Substring(startIndex, length)

#### Replacing

- Replace('a', '!')
- Replace("mosh", "moshfegh")

#### Null Checking

- String.IsNullOrEmpty(str)
- String.IsNullOrWhiteSpace(str)

#### Splitting

str.Split(' ')

### Converting a String to a Number

```csharp
string s = "1234";
int i = int.Parse(s);
int j = Convert.ToInt32(s)
```

### Converting a Number to a String

```csharp
int i = 1234;
string s = i.ToString();        // "1234"
string t = i.ToString("C");     // "$1,234.00"
string t = i.ToString("C0");    // "$1,234"
```
