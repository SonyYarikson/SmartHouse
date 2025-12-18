using SmartHouse.Data;
using SmartHouse.Devices;
using SmartHouse.Interfaces;

namespace SmartHouse.Logic;

public class StrategyManager
{
    public static IHouseEventsStrategy SetStrategy(HouseEvents e)
    {
        switch (e)
        {
            case HouseEvents.EVENING_MODE:

            {
                var dimmableLamp = (DimmableLamp)SmartHomeHub.GetInstance().Devices
                    .FirstOrDefault(x => x is DimmableLamp dimmableLamp);
                if (dimmableLamp != null)
                {
                    return new EveningModeStrategy(dimmableLamp);
                }
                throw new Exception("No lamp found");
                
            }
            case HouseEvents.ALL_OFF:
            {
                return new AwayModeStrategy(SmartHomeHub.GetInstance().Devices);
            }
            case HouseEvents.SECURITY_BREACH:
                return new SecurityBreachStrategy(SmartHomeHub.GetInstance().Devices);
            default: return new AwayModeStrategy(SmartHomeHub.GetInstance().Devices);
        }
    }
    
}