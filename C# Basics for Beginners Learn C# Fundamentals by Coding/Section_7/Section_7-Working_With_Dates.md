# Working with Date and Time in C#

## DateTime

C# includes DateTime struct to work with dates and times.

To work with date and time in C#, create an object of the DateTime struct using the new keyword. The following creates a DateTime object with the default value.

#### Example: Create DateTime Object

```csharp
DateTime dt = new DateTime(); // assigns default value 01/01/0001 00:00:00
```

The default and the lowest value of a DateTime object is January 1, 0001 00:00:00 (midnight). The maximum value can be December 31, 9999 11:59:59 P.M.

Use different constructors of the DateTime struct to assign an initial value to a DateTime object.

#### Example: Set Date & Time

```csharp
//assigns default value 01/01/0001 00:00:00
DateTime dt1 = new DateTime();

//assigns year, month, day
DateTime dt2 = new DateTime(2015, 12, 31);

//assigns year, month, day, hour, min, seconds
DateTime dt3 = new DateTime(2015, 12, 31, 5, 10, 20);

//assigns year, month, day, hour, min, seconds, UTC timezone
DateTime dt4 = new DateTime(2015, 12, 31, 5, 10, 20, DateTimeKind.Utc);
```

In the above example, we specified a year, a month, and a day in the constructor. The year can be from 0001 to 9999, and the Month can be from 1 to 12, and the day can be from 1 to 31. Setting any other value out of these ranges will result in a run-time exception.

#### Example: Invalid Date

```csharp
DateTime dt = new DateTime(2015, 12, 32); //throws exception: day out of range
```

Use different DateTime constructors to set date, time, time zone, calendar, and culture.

## Ticks

# TimeSpan
