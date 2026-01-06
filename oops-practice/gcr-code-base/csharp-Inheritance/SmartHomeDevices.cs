using System;
class Device
{
    public int deviceId;
    public string status;
    public Device(int deviceId, string status)
    {
        this.deviceId = deviceId;
        this.status = status;
    }
    public void DisplayStatus()
    {
        Console.WriteLine("Device ID: " + this.deviceId + ", Status: " + this.status);
    }
}
class Thermostat : Device
{
    public double temperatureSetting;
    public Thermostat(int deviceId, string status, double temperatureSetting) : base(deviceId, status)
    {
        this.temperatureSetting = temperatureSetting;
    }
    public void DisplayStatus()
    {
       base.DisplayStatus();
       Console.WriteLine("Temperature Setting: " + this.temperatureSetting);
    }
}

class SmartHomeDevices
{
    static void Main(string[] args)
    {
        Device d1 = new Device(1, "ON");
        d1.DisplayStatus();
        Thermostat t1 = new Thermostat(2, "OFF", 23.5);
        t1.DisplayStatus();
    }
}