# C# Constructor NullReferenceException: Accessing Uninitialized Property

This repository demonstrates a common C# error: a `NullReferenceException` occurring within a constructor because a property is accessed before it's initialized.  The `Bug.cs` file shows the problematic code, while `BugSolution.cs` provides the corrected version.

## Problem

In the `ExampleClass` constructor, `MyProperty` is used in the calculation `value + MyProperty` before it's assigned a value. This leads to a `NullReferenceException`.

## Solution

The solution is to initialize `MyProperty` either directly in the class declaration or at the very start of the constructor before its value is used in any calculations.
