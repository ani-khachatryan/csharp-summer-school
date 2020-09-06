using System;
using System.Collections.Generic;


public abstract class Mobile
{
    //public string Name;

    public abstract string Vendor { get; set; }
    public string esime { get; set; } = "esim";
    //public string InternalStorage { get; set; }
    //public string RAM { get; set; }
    //public string Processor { get; set; }
    //public string Display { get; set; }
    //public string MainCamera { get; set; }
    //public string FrontalCamera { get; set; }

    public Dictionary<string, string> Characteristics = new Dictionary<string, string>();
    public abstract void Root();

    public void DisplayName()
    {
        Console.WriteLine($"{Characteristics["Name"]}");   
    }
    public void DisplayCharacteristics()
    {
        foreach (var item in Characteristics)
        {
            Console.WriteLine($"{item.Key}:    {item.Value}");
        }
        Console.WriteLine();
    }
}