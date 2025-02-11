public class ExampleClass
{
    public int MyProperty { get; set; }

    // Constructor to initialize the property
    public ExampleClass()
    {
        MyProperty = 0; // Initialize with a default value
    }

    public void MyMethod()
    {
        Console.WriteLine(MyProperty); // Now the property has a defined value
    }
}