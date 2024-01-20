# About

For showing benefits of using Interfaces in regards to consistency.

The base code can be found in ConsistencySampleLibrary for interfaces and EF Core data operations.

- **Code maintainability**: Interfaces helps to reduce coupling and therefore allow you to easily interchange implementations for the same concept without the underlying code being affected. You can change the implementation of a IMessage easily by defining a new class that implements the interface. Compare that to sistematically[^1] replacing all references from CMessage to CMyNewMessageClass.

- **Code readability**: An interface constitutes a declaration about intentions. It defines a capability of your class, what your class is capable of doing. If you implement ISortable you're clearly stating that your class can be sorted.
- **Code semantics**: By providing interfaces and implementing them you're actively separating concepts in a similar way HTML and CSS does. A class is a concrete implementation of an "object class" some way of representing the reality by modeling general properties of real life objects or concepts. An interface define a behavioral model, a definition of what an object can do. Separating those concepts keeps the semantics of your code more clear. That way some methods may need an instance of an animal class while other may accept whatever object you throw at them as long as it supports "walking".


[^1]: If you do something systematically, you do it in an orderly, methodical way. Someone who systematically records her dreams is careful to write them in a notebook every single morning. Use the adverb systematically when you describe something that's carried out in a deliberate way, especially following a plan.

