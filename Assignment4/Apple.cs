using System;

public class Apple : Mobile
{
    public override string Vendor { get; set; } = "Apple";

    public override void Root()
    {
        Console.WriteLine($"{Vendor}:    The user can not have root access!\n");
    }
}