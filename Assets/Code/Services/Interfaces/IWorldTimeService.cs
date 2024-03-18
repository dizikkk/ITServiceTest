using Zenject;

namespace ITServiceTest
{
    public interface IWorldTimeService : IInitializable
    {
        public void PauseTime();
        public void UnpauseTime();
    }
}