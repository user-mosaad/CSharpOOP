# C# Object-Oriented Programming
In C#, the definition of a type - a class, struct or record - is like a blueprint that specifies what the type can do.

An object is basically a block of memory allocated and configured according to the blueprint.

## 4 Pillars of OOP
### Encapsulation
A class or struct can specify how accessible each of its members is to code outside of the class or struct. Members not intended for consumers outside of the class or assembly are hidden to limit the potential for coding errors or malicious exploits.

### Abstraction
Hides complex background details and shows only the essential features to the user. Focuses on what an object does instead of how it does it, often using abstract classes or interfaces.

### Inheritance
Classes (but not structs) support the concept of inheritance. A class that derives *(derived class)* from another class, called the *base class*, automatically contains all the `public`, `protected`, and `internal` members of the base class except its constructors and finalizers.

Classes can be declared as abstract, which means that one or more of their methods have no implementation. Although abstract classes can't be instantiated directly, they can serve as base classes for other classes that provide the missing implementation. Classes can also be declared as sealed to prevent other classes from inheriting from them.

### Polymorphism
Means "many forms," allowing the same method or interface to behave differently based on the object calling it. It's achieved through method overriding (subclasses changing a parent's method) or method overloading (same method name with different parameters).

Example: a `speak()` action. A `Cat` object responds with 'Meow' and a `Dog` object responds with 'Bark' using the exact same command name.

## Members
The following list includes all the various kinds of members that can be declared in a class, struct, or record.
- Fields
- Constants
- Properties
- Methods
- Constructors
- Events
- Finalizers
- Indexers
- Operators
- Nested Types

## Accessibility
Some methods and properties are meant to be called or accessed from code outside a class or struct, known as *client code*.

You specify how accessible your types and their members are to client code by using the following access modifiers:
- `public`
- `protected`
- `internal`
- `protected internal`
- `private`
- `private protected`

The default accessibility inside types is `private`.

## Interfaces
Classes, structs, and records can implement multiple interfaces. To implement from an interface means that the type implements all the methods defined in the interface.

## Generic Types
Classes, structs and records can be defined with one or more type parameters. Client code supplies the type when it creates an instance of the type. For example, the `List<T>` class in the `System.Collections.Generic` namespace is defined with one type parameter. Client code creates an instance of a `List<string>` or `List<int>` to specify the type that the list holds.

## Static Types
Classes (but not structs or records) can be declared as `static`. A static class can contain only static members and can't be instantiated with the `new` keyword. One copy of the class is loaded into memory when the program loads, and its members are accessed through the class name. Classes, structs, and records can contain static members.

## Nested Types
A class, struct, or record can be nested within another class, struct, or record.

## Partial Types
You can define part of a class, struct, or method in one code file and another part in a separate code file.

## Object Initialisers
You can instantiate and initialize class or struct objects, and collections of objects, by assigning values to its properties.

## Anonymous Types
In situations where it isn't convenient or necessary to create a named class, you can use anonymous types or tuples. Named data members define anonymous types. Tuples are the preferred choice for new code because they offer better performance and deconstruction support.

## Extension Members
You can 'extend' a class without creating a derived class by creating a separate type. That type contains methods that can be called as if they belonged to the original type.

## Implicitly Typed Local Variables
Within a class or struct method, you can use implicit typing to instruct the compiler to determine a variable's type at compile time using `var`.

## Records
You can add the `record` modifier to a class or a struct. Records are types with built-in behavior for value-based equality. A record (either `record class` or `record struct`) provides the following features:
- Concise syntax for creating a reference type with immutable properties.
- Value equality. Two variables of a record type are equal if they have the same type, and if, for every field, the values in both records are equal. Classes use reference equality: two variables of a class type are equal if they refer to the same object.
- Concise syntax for nondestructive mutation. A `with` expression lets you create a new record instance that is a copy of an existing instance but with specified property values changed.
- Built-in formatting for display. The `ToString` method prints the record type name and the names and values of public properties.
- Support for inheritance hierarchies in record classes. Record classes support inheritance. Record structs don't support inheritance.
