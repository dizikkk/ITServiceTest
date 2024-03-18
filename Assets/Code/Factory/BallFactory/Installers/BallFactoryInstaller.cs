using UnityEngine;
using Zenject;

namespace ITServiceTest
{
    public class BallFactoryInstaller : MonoInstaller
    {
        [SerializeField]
        private BallFactoryConfig config;
        public override void InstallBindings()
        {
            BindBallFactoryData();
            BindBallFactory();
        }

        private void BindBallFactoryData() => Container.Bind<BallFactoryConfig>().FromInstance(config).AsSingle();

        private void BindBallFactory() => Container.Bind<IBallFactory>().To<BallFactory>().AsSingle();
    }
}