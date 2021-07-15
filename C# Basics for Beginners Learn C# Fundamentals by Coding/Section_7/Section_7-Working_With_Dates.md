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

## TimeSpan

TimeSpan is a struct that is used to represent time in days, hour, minutes, seconds, and milliseconds.

#### Example: TimeSpan

```csharp
DateTime dt = new DateTime(2015, 12, 31);

TimeSpan ts = new TimeSpan(25,20,55);

DateTime newDate = dt.Add(ts);

Console.WriteLine(newDate);//1/1/2016 1:20:55 AM
```

Subtraction of two dates results in TimeSpan.

#### Example: Subtract Dates

```csharp
DateTime dt1 = new DateTime(2015, 12, 31);
DateTime dt2 = new DateTime(2016, 2, 2);
TimeSpan result = dt2.Subtract(dt1);//33.00:00:00
```

## Operators

The DateTime struct overloads +, -, ==, !=, >, <, <=, >= operators to ease out addition, subtraction, and comparison of dates. These make it easy to work with dates.

#### Example: Operators

```csharp
DateTime dt1 = new DateTime(2015, 12, 20);
DateTime dt2 = new DateTime(2016, 12, 31, 5, 10, 20);
TimeSpan time = new TimeSpan(10, 5, 25, 50);

Console.WriteLine(dt2 + time); // 1/10/2017 10:36:10 AM
Console.WriteLine(dt2 - dt1); //377.05:10:20
Console.WriteLine(dt1 == dt2); //False
Console.WriteLine(dt1 != dt2); //True
Console.WriteLine(dt1 > dt2); //False
Console.WriteLine(dt1 < dt2); //True
Console.WriteLine(dt1 >= dt2); //False
Console.WriteLine(dt1 <= dt2);//True
```

## Convert DateTime to String

The DateTime struct includes the following methods to convert a date and time to string.
|Method|Description|
|---|---|
|ToString|Converts a DateTime value to a string in the specified format of the current culture.|
|ToShortDateString| Converts a DateTime value to a short date string (M/d/yyyy pattern) in the current culture.|
|ToShortTimeString|Converts a DateTime value to a short time string (h:mm:ss pattern) in the current culture.|
|ToLongDateString|Converts a DateTime value to a long date string (dddd, MMMM d, yyyy pattern) in the current culture.|
|ToLongTimeString|Converts a DateTime value to a long time string (h:mm:ss tt pattern) in the current culture.|

The following example demonstrates converting DateTime to strings in different formats.

#### Example: DateTime to String

```csharp
var dt = DateTime.Now;

Console.WriteLine("Date String Current Culture: " + dt.ToString("d"));
Console.WriteLine("MM/dd/yyyy Format: " + dt.ToString("MM/dd/yyyy"));
Console.WriteLine("dddd, dd MMMM yyyy Format: " + dt.ToString("dddd, dd MMMM yyyy"));
Console.WriteLine("MM/dd/yyyy h:mm tt Format: " + dt.ToString("MM/dd/yyyy h:mm tt"));
Console.WriteLine("MMMM dd Format:" + dt.ToString("MMMM dd"));
Console.WriteLine("HH:mm:ss Format: " + dt.ToString("HH:mm:ss"));
Console.WriteLine("hh:mm tt Format: " + dt.ToString("hh:mm tt"));
Console.WriteLine("Short Date String: " + dt.ToShortDateString());
Console.WriteLine("Long Date String: " + dt.ToLongDateString());
Console.WriteLine("Short Time String: " + dt.ToShortTimeString());
Console.WriteLine("Long Time String: " + dt.ToLongTimeString());
```

## Convert String to DateTime

A valid date and time string can be converted to a DateTime object using Parse(), ParseExact(), TryParse() and TryParseExact() methods.

The Parse() and ParseExact() methods will throw an exception if the specified string is not a valid representation of a date and time. So, it's recommended to use TryParse() or TryParseExact() method because they return false if a string is not valid.

#### Example:

```csharp
var str = "5/12/2020";
DateTime dt;

var isValidDate = DateTime.TryParse(str, out dt);

if(isValidDate)
    Console.WriteLine(dt);
else
    Console.WriteLine($"{str} is not a valid date string");
```
