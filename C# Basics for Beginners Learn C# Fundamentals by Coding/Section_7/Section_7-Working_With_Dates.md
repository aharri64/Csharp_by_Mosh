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

Ticks is a date and time expressed in the number of 100-nanosecond intervals that have elapsed since January 1, 0001, at 00:00:00.000 in the Gregorian calendar. The following initializes a DateTime object with the number of ticks.

#### Example: Ticks

```csharp
DateTime dt = new DateTime(636370000000000000);
DateTime.MinValue.Ticks;  //min value of ticks
DateTime.MaxValue.Ticks; // max value of ticks
```

## DateTime Static Fields

The DateTime struct includes static fields, properties, and methods. The following example demonstrates important static fields and properties.

#### Example: Static Fields

```csharp
DateTime currentDateTime = DateTime.Now;  //returns current date and time
DateTime todaysDate = DateTime.Today; // returns today's date
DateTime currentDateTimeUTC = DateTime.UtcNow;// returns current UTC date and time

DateTime maxDateTimeValue = DateTime.MaxValue; // returns max value of DateTime
DateTime minDateTimeValue = DateTime.MinValue; // returns min value of DateTime
```

# TimeSpan
