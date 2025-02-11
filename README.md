# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property before it's been initialized.  Uninitialized properties can lead to unpredictable behavior and unexpected results.  This example highlights the issue and presents a solution.

**Problem:** The `ExampleClass` attempts to access the `MyProperty` before a value is assigned.  The result depends on the .NET environment and could lead to bugs in real-world applications.

**Solution:** Initialize the property with a default value in the constructor or assign a value before accessing it.