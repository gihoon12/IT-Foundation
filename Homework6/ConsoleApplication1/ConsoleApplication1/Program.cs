using System;

class MyString
{
    // "normal" fields (X) and readonly fields
    // can be initialized in the constructor
    public MyString(string str)
    {
        Str = str;
        Length = str.Length;
    }

    // "normal" field (variable)
    public string Str;

    // readonly fields can only be initialized
    // here or in the constructor
    public readonly int Length = 0;

    // const fields must use simple types
    // such as a byte, int, long, float, etc
    public const int MaxLength = 255;

}

class TestMyString
{
    static void Main()
    {
        MyString mystr = new MyString("Test me");

        // Initialize a "normal" field
        mystr.Str = "Hello";

        // Error: The following field
        // is readonly
        //mystr.Length = 5;

        Console.WriteLine("Str is {0}",
            mystr.Str);

        Console.WriteLine("Length is {0}",
            mystr.Length);

        // Because MaxLength is a const field, you must
        // access it through its class name
        Console.WriteLine("Length is {0}",
            MyString.MaxLength);

        Console.ReadLine();
    }
}