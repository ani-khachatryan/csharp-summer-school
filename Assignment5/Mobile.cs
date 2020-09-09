using System;
using System.Collections.Generic;


public abstract class Mobile
{
    //public string Name;

    public abstract string Vendor { get; set; }
    public string esime { get; set; } = "esim";
    public Dictionary<string, string> Characteristics { get; set; } = new Dictionary<string, string>();
    
    //public string InternalStorage { get; set; }
    //public string RAM { get; set; }
    //public string Processor { get; set; }
    //public string Display { get; set; }
    //public string MainCamera { get; set; }
    //public string FrontalCamera { get; set; }

    //private Dictionary<string, string> characteristics = new Dictionary<string, string>();
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