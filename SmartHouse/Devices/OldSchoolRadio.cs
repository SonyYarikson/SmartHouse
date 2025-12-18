using SmartHouse.Interfaces;

namespace SmartHouse.Devices;

public class OldSchoolRadio : IOldSchoolRadio
{
    private int _volume;

    public OldSchoolRadio(int volume)
    {
        _volume = volume;
    }
    public virtual void PowerOn()
    {
        Console.WriteLine("Радио включено");
    }

    public virtual void PowerOff()
    {
        Console.WriteLine("Радио выключено");
    }

    public void SetVolume(int volume)
    {
        _volume = volume;
    }
}