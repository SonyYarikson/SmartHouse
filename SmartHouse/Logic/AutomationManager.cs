using SmartHouse.Data;
using SmartHouse.Interfaces;

namespace SmartHouse.Logic;

public class AutomationManager : IObserver
{
    private IHouseEventsStrategy _eventsStrategy;

    public AutomationManager(IHouseEventsStrategy eventsStrategy)
    {
        _eventsStrategy = eventsStrategy;
    }
    public void Update(HouseEvents e)
    {
       _eventsStrategy = StrategyManager.SetStrategy(e);
       _eventsStrategy.Execute();
    }

}