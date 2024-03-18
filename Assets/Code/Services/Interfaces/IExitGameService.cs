using Zenject;

namespace ITServiceTest
{
    public interface IExitGameService : IInitializable
    {
        public void Exit();
    }
}