using SmartHouse.Data;
using SmartHouse.Devices;
using SmartHouse.Interfaces;

namespace SmartHouse.Logic;

public class SmartHomeHub : IObservable
{
    private static SmartHomeHub instance;
    private List<IObserver> observers;
    public List<Device> Devices { get; private set; }
    private SmartHomeHub()
    {}

    public static SmartHomeHub GetInstance()
    {
        if (instance == null)
            instance = new SmartHomeHub();
        return instance;
    }
    

    public void AddObserver(IObserver o)
    {
        observers.Add(o);
    }

    public void RemoveObserver(IObserver o)
    {
        observers.Remove(o);
    }
    

    public void NotifyObservers(HouseEvents e)
    {
        foreach (var o in observers)
        {
            o.Update(e);
        }
    }

    public void RegisterDevice(Device d)
    {
        Devices.Add(d);
    }
}