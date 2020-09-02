using System;

public class Nokia : Mobile
{
    public override string Vendor { get; set; } = "Nokia";
    public override void Root()
    {
        Console.WriteLine($"{this.Vendor}:    The user can have root access!\n");
    }
}