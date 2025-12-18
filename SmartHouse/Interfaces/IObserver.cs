using SmartHouse.Data;

namespace SmartHouse.Interfaces;

public interface IObserver
{
    void Update(HouseEvents e);
}