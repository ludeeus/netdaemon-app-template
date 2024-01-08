using LightManagerV2;

namespace Niemand.Tests.Mocks;

public class RandomManagerMock : IRandomManager
{
    public SwitchEntity RandomSwitchEntity { get; }
    public TimeSpan RandomDelay { get; set; }
    public void Init(LightEntity entity, IEnumerable<string> randomStates)
    {
        throw new NotImplementedException();
    }

    public void Init(IEnumerable<LightEntity> entities, IEnumerable<string> randomStates)
    {
        throw new NotImplementedException();
    }

    public void StartQueue()
    {
        throw new NotImplementedException();
    }

    public void StopQueue()
    {
        throw new NotImplementedException();
    }
}