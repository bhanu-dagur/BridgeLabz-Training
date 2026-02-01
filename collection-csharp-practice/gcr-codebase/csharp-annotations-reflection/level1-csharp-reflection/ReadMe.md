# 📘 Reflection in C# – 

---

## 🔹 What is Reflection? (Definition)

Reflection is a feature in C# that allows a program to inspect, access, and manipulate
its own structure (classes, methods, fields, properties, and attributes) at runtime.

In simple words, Reflection allows a program to examine and execute code dynamically
while the application is running.

---

## 🔹 Why Reflection Came Into the Picture?

Normal C# programs are static in nature.  
Everything (class name, method name, object creation) is decided at compile time.

Example:

Student s = new Student();

s.Display();

## This approach works well for small applications but fails in modern systems that require:

Dynamic behavior

Framework-based development

Plugin systems

Configuration-driven logic

Reflection was introduced to solve these problems by allowing runtime inspection
and execution of code.

-----
## Reflection flow chart

Class / Object
     ↓
   Type
     ↓
 Metadata (methods, fields, attributes)
     ↓
 Reflection APIs
     ↓
 Dynamic execution

🔹 Core Reflection Classes in C#

Class Name	     |           Purpose
-----------------|------------------------------------------
Type	         |           Provides class metadata
MethodInfo       |           Represents methods
FieldInfo        |	         Represents fields
PropertyInfo     |           Represents properties
ConstructorInfo  |           Represents constructors
Assembly         |           Represents DLL / EXE
Activator        |           Creates objects dynamically

--------

Q: Why is Reflection slower than normal code?

-Because it bypasses compile-time checks and operates on metadata at runtime.

Q: Can Reflection access private members?

-Yes, by using appropriate BindingFlags.

Q: Where is Reflection used in real-world applications?

-Dependency Injection, Logging, Serialization, Frameworks, and T

--------------

🔹 Final Interview Summary (30-Second Answer)

Reflection is a powerful feature in C# that allows runtime inspection and execution of code.
It is used when types and methods are not known at compile time, such as in dependency
injection, logging, serialization, and frameworks. Although Reflection is slower and less
safe than direct calls, it provides the flexibility required to build modern dynamic
applications.

Normal Code = Fixed Road
Reflection = GPS (Dynamic Route)
