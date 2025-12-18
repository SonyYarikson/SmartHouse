using SmartHouse.Data;

namespace SmartHouse.Interfaces;

public interface IObservable
{
    void AddObserver(IObserver o);
    void RemoveObserver(IObserver o);
    void NotifyObservers(HouseEvents e);
}