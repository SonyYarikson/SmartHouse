using SmartHouse.Devices;
using SmartHouse.Interfaces;

namespace SmartHouse.Logic;

public class SecurityBreachStrategy : IHouseEventsStrategy
{
    private List<Device> _devices;

    public SecurityBreachStrategy(List<Device> devices)
    {
        _devices = devices; 
    }
    public void Execute()
    {
        foreach (var device in _devices)
        {
            device.turnOff();
        }
        
    }
}