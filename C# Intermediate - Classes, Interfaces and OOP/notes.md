# Section 2: Classes

## Introduction to Classes

### What is a class

A building block of software applications

![application](./pics/application.png)

### Real-world example of classes

![Real World Example](./pics/real_world_example.png)

### Anatomy of a class

- Data (represented by fields)
- Behavior (represented by methods/functions)

![person classes](./pics/personclass.png)
![post classes](./pics/post_class.png)

### What is an object

- An instance of a class.

![person objects](./pics/person_objects.png)

### Declaring a class in C#

![declared classes](./pics/declarclass.png)
![declared Method](./pics/declaremethod.png)
![creating objects](./pics/creatingobjects.png)
![using objects](./pics/usingobjects.png)

### Class Members

![class Members](./pics/classmembers.png)
2 types

### Why Use Static Members?

- To represent concepts that are singleton.
- DateTime.Now
- Console.WriteLine()

![declaring a static member](./pics/declareastaticmember.png)

## Constructors

**What is a constructor -**
A method that is called when an instance of a class is created.

**Why do we need a constructor -**
To put an object in an early state.

**Ho wto declare a constructor**
![how we declare a constructor](./pics/decareacontructor.png)

- this is a default or parameterless constructor

**Constructor Example 2**
![constructor example 2](./pics/constructorexample2.png)'

**Constructor Overloading**
![Example of Constructor Overloading](./pics/constructoroverloading.png)

- **Overloading** - Having a method of the same name but different signatures

---

## Object Initializers

- An object initializer is a syntax for quickly initializing an object without the need to call one of its constructors.

- Why do you need one? To avoid creating multiple constructors

This is how they used to do things
![This is how they used to do things](./pics/ObjectInitializers.png)

This is an object initializer
![objectinitializerstrue](./pics/objectinitializerstrue.png)

---

## Methods

### Agenda

- Signature of methods
- Method Overloading
- Params modifier
- Ref modifier
- Out modifier

### Signature of a Method

- Consists of:
  - Name
  - Number nd Type of parameters

![signatureofamethod](./pics/signatureofamethod.png)

![methods1](./pics/methods1.png)

### Method Overloading

![methods2](./pics/methods2.png)
_this is not efficient_

![methods3](./pics/methods3.png)
_this is much more efficient_

_the problem is that when we want to pass a number of arguments to this add method, we have to create and initialize and array_

### Params Modifier

![methods4](./pics/methods4.png)

### Ref Modifier

This is inefficient and no one really uses it
![refmodifier](./pics/refmodifier.png)
![refmodifier2](./pics/refmodifier2.png)

## Out Modifier

![outmodifier](./pics/outmodifier.png)
