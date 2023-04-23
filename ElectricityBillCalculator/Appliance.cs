using System;

public class Appliance
{
    public Appliance(string name, int wattage, int hrsPerDay)
    {
        this.Name = name;
        this.Wattage = wattage;
        this.HrsPerDay = hrsPerDay;
    }

    public override string ToString() //Required to display proper appliance name in list
    {
        return Name;
    }

    public string Name;
    public float Wattage;
    public float HrsPerDay;
    public float AppCost = 0f;
}
