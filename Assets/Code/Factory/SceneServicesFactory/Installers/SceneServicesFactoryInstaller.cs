using UnityEngine;
using Zenject;

namespace ITServiceTest
{
    public class SceneServicesFactoryInstaller : MonoInstaller
    {
        [SerializeField]
        private SceneServicesConfig config;

        public override void InstallBindings()
        {
            BindSceneServicesData();
            BindSceneServicesFactory();
        }

        private void BindSceneServicesData() => Container.Bind<SceneServicesConfig>().FromInstance(config).AsSingle();

        private void BindSceneServicesFactory()
        {
            Container.Bind<ISceneServicesFactory>().To<SceneServicesFactory>().AsSingle();
        }
    }
}