public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        // This line will throw a NullReferenceException if MyProperty is not initialized before accessing it
        MyProperty = value + MyProperty; 
    }
}