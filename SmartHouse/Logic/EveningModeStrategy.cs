using SmartHouse.Devices;
using SmartHouse.Interfaces;

namespace SmartHouse.Logic;

public class EveningModeStrategy : IHouseEventsStrategy
{
    private DimmableLamp _dimmableLamp;

    public EveningModeStrategy(DimmableLamp dimmableLamp)
    {
        _dimmableLamp = dimmableLamp;   
    }
    public void Execute()
    {
        _dimmableLamp.BrightnessDimmer.ChangeScale(50);
    }
}