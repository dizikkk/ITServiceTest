using UnityEngine;
using Zenject;

namespace ITServiceTest
{
    public class BallFactory : IBallFactory
    {
        private readonly DiContainer diContainer;
        private readonly BallFactoryConfig config;
        
        public BallFactory(DiContainer diContainer, BallFactoryConfig config)
        {
            this.diContainer = diContainer;
            this.config = config;
        }

        public void Create()
        {
            Ball ball = diContainer.InstantiatePrefabForComponent<Ball>(config.ballPrefab, config.spawnPosition,
                Quaternion.identity, null);

            diContainer.Bind<Ball>().FromInstance(ball);
        }
    }
}