using SmartHouse.Devices;
using SmartHouse.Interfaces;

namespace SmartHouse.Logic;

public class AwayModeStrategy : IHouseEventsStrategy
{
    private List<Device> _devices;

    public AwayModeStrategy(List<Device> devices)
    {
        _devices = devices;
    }
    public void Execute()
    {
        foreach (var device in _devices)
        {
            if (device is Thermostat thermostat)
            {
                thermostat.TemperatureDimmer.ChangeScale(16);
            }
            device.turnOff();
            
        }
        
    }
}