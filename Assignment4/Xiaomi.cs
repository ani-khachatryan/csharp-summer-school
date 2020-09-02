using System;

public class Xiaomi : Mobile
{
    public override string Vendor { get; set; } = "Xiaomi";
    public override void Root()
    {
        Console.WriteLine($"{this.Vendor}:    The user can have root access!\n");
    }
}
