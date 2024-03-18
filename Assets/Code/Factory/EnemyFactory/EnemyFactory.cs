using UnityEngine;
using Zenject;

namespace ITServiceTest
{
    public class EnemyFactory : IEnemyFactory
    {
        private readonly DiContainer diContainer;
        private readonly EnemyFactoryConfig config;
        
        public EnemyFactory(DiContainer diContainer, EnemyFactoryConfig config)
        {
            this.diContainer = diContainer;
            this.config = config;
        }
        
        public void Create()
        {
            Enemy enemy = diContainer.InstantiatePrefabForComponent<Enemy>(
                config.enemyPrefab,
                config.spawnPosition,
                Quaternion.identity,
                null);

            diContainer.Bind<Enemy>().FromInstance(enemy);
        }
    }
}