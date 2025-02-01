public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize property with a default value

    public ExampleClass(int value)
    {
        MyProperty = value + MyProperty; 
    }
} 