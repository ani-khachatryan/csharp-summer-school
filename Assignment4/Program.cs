using System;
using System.Text;
using System.Threading;

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Mobile iPhone9 = new Apple();
        Mobile RedmiNote9S = new Xiaomi();
        Mobile NokiaX6 = new Nokia();

        iPhone9.Root();
        NokiaX6.Root();

        iPhone9.Characteristics.Add("Name", "iPhone9");
        iPhone9.Characteristics.Add("Processor", "A13 Bionic chip");
        iPhone9.Characteristics.Add("RAM", "6GB");
        iPhone9.Characteristics.Add("InternalStorage", "256GB");
        iPhone9.Characteristics.Add("MainCamera", "12MP");
        iPhone9.Characteristics.Add("Display", "Brilliant 4.7” Retina HD display");

        RedmiNote9S.Characteristics.Add("Name", "RedmiNote9S");
        RedmiNote9S.Characteristics.Add("Processor", "Qualcomm® Snapdragon™ 720G.");
        RedmiNote9S.Characteristics.Add("RAM", "4GB");
        RedmiNote9S.Characteristics.Add("InternalStorage", "64GB");
        RedmiNote9S.Characteristics.Add("MainCamera", "48Mp");
        RedmiNote9S.Characteristics.Add("Display", "6.67\" DotDisplay");


        NokiaX6.Characteristics.Add("Name", "NokiaX6");
        NokiaX6.Characteristics.Add("Processor", "Qualcomm® Snapdragon™ 636.");
        NokiaX6.Characteristics.Add("RAM", "6GB");
        NokiaX6.Characteristics.Add("InternalStorage", "64GB");
        NokiaX6.Characteristics.Add("MainCamera", "16MP");
        NokiaX6.Characteristics.Add("Display", "5.8\" IPS LCD");

        iPhone9.DisplayCharacteristics();
        Console.WriteLine($"Vendor:    {iPhone9.Vendor}");

        NokiaX6.DisplayCharacteristics();
        RedmiNote9S.DisplayCharacteristics();
        Thread.Sleep(6000);
    }
}