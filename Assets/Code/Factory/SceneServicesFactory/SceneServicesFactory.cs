using Zenject;

namespace ITServiceTest
{
    public class SceneServicesFactory : ISceneServicesFactory
    {
        private DiContainer diContainer;
        private SceneServicesConfig config;

        public SceneServicesFactory(DiContainer diContainer, SceneServicesConfig config)
        {
            this.diContainer = diContainer;
            this.config = config;
        }

        public void Create()
        {
            ILevelService levelService = diContainer.InstantiatePrefabForComponent<LevelService>(config.levelServicePrefab);
            diContainer.Bind<ILevelService>().FromInstance(levelService);
            //diContainer.BindInterfacesAndSelfTo<LevelService>().FromInstance(levelService);
        }
    }
}