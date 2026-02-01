using System;

class API
{
    [Obsolete("OldFeature is deprecated. Please use NewFeature instead.")]
    public void OldFeature()
    {
        Console.WriteLine("This is the old Feature");
    }

    public void NewFeature()
    {
        Console.WriteLine("This is the new Feature");
    }
}

class LegacyAPI
{
    public static void Main()
    {
        API api=new API();

        //Old method shows warning
        api.OldFeature();

        //Calling new Method
        api.NewFeature();
    }
}
/*
Why Obsolete Attribute is used?

- To inform developers that a method/class is outdated
- To maintain backward compatibility
- To guide developers towards newer APIs

*/