using UnityEditor;
using Zenject;

namespace ITServiceTest
{
    public interface IRestartGameService : IInitializable
    {
        public void RestartGame(SceneAsset scene);
    }
}